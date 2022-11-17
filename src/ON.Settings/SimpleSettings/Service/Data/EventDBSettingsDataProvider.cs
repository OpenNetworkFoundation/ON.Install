﻿using EventStore.Client;
using Grpc.Net.Client.Balancer;
using Microsoft.Extensions.Logging;
using ON.Fragments.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ON.Settings.SimpleSettings.Service.Data
{
    public class EventDBSettingsDataProvider : ISettingsDataProvider
    {
        private readonly ILogger logger;

        private string connStr = "esdb://127.0.0.1:2113?tls=false&keepAliveTimeout=10000&keepAliveInterval=10000";
        private EventStoreClient client;
        private string streamName = "simplesettings";

        public EventDBSettingsDataProvider(ILogger<EventDBSettingsDataProvider> logger)
        {
            this.logger = logger;

            var settings = EventStoreClientSettings.Create(connStr);
            client = new EventStoreClient(settings);
        }

        public async Task Clear()
        {
            await client.DeleteAsync(streamName, StreamState.Any);
        }

        public async Task<SettingsRecord> Get()
        {
            try
            {
                var result = client.ReadStreamAsync(
                    Direction.Backwards,
                    streamName,
                    StreamPosition.End);

                var e = await result.FirstOrDefaultAsync();
                var json = Encoding.ASCII.GetString(e.Event.Data.Span);
                var record = Google.Protobuf.JsonParser.Default.Parse<SettingsRecord>(json);

                return record;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error in Get()");
            }

            return null;
        }

        public async IAsyncEnumerable<SettingsRecord> GetAll()
        {
            try
            {
                var result = client.ReadStreamAsync(
                    Direction.Backwards,
                    streamName,
                    StreamPosition.End);

                await foreach (var e in result)
                {
                    var json = Encoding.ASCII.GetString(e.Event.Data.Span);
                    var record = Google.Protobuf.JsonParser.Default.Parse<SettingsRecord>(json);
                    yield return record;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error in GetAll()");
            }
        }

        public async Task Save(SettingsRecord record)
        {
            try
            {
                var json = Google.Protobuf.JsonFormatter.Default.Format(record);

                var eventData = new EventData(
                    Uuid.NewUuid(),
                    nameof(SettingsRecord),
                    Encoding.ASCII.GetBytes(json)
                );

                await client.AppendToStreamAsync(
                                streamName,
                                StreamState.Any,
                                new[] { eventData }
                        );
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error in Save()");
            }
        }
    }
}

﻿using Grpc.Core;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ON.Authentication;
using ON.Fragments.Authorization;
using ON.Fragments.Authorization.Payments.Paypal;
using ON.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ON.SimpleWeb.Services.Paypal
{
    public class AccountService
    {
        private readonly ILogger<AccountService> logger;
        private readonly ServiceNameHelper nameHelper;

        public readonly string AccountId;
        public readonly PlanRecord[] Plans;

        public AccountService(ServiceNameHelper nameHelper, ILogger<AccountService> logger)
        {
            this.logger = logger;
            this.nameHelper = nameHelper;

            var res = GetDetails();
            AccountId = res.ClientId;
            Plans = res.Plans.Records.ToArray();
        }

        private GetAccountDetailsResponse GetDetails()
        {
            if (nameHelper.PaypalPaymentsServiceChannel == null)
                return null;

            var client = new PaymentsInterface.PaymentsInterfaceClient(nameHelper.PaypalPaymentsServiceChannel);
            var reply = client.GetAccountDetails(new GetAccountDetailsRequest());
            return reply;
        }
    }
}

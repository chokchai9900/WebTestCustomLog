using System;
using System.Collections.Generic;

namespace WebTestCustomLog.Models
{
    public class CommonAlertSchemaModel
    {
        public string schemaId { get; set; }
        public Data data { get; set; }
    }

    public class Essentials
    {
        public string alertId { get; set; }
        public string alertRule { get; set; }
        public string severity { get; set; }
        public string signalType { get; set; }
        public string monitorCondition { get; set; }
        public string monitoringService { get; set; }
        public List<string> alertTargetIDs { get; set; }
        public List<string> configurationItems { get; set; }
        public string originAlertId { get; set; }
        public DateTime firedDateTime { get; set; }
        public DateTime resolvedDateTime { get; set; }
        public string description { get; set; }
        public string essentialsVersion { get; set; }
        public string alertContextVersion { get; set; }
    }

    public class Dimension
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class AllOf
    {
        public string metricName { get; set; }
        public string metricNamespace { get; set; }
        public string @operator { get; set; }
        public string threshold { get; set; }
        public string timeAggregation { get; set; }
        public List<Dimension> dimensions { get; set; }
        public double metricValue { get; set; }
    }

    public class Condition
    {
        public string windowSize { get; set; }
        public List<AllOf> allOf { get; set; }
    }

    public class AlertContext
    {
        public object properties { get; set; }
        public string conditionType { get; set; }
        public Condition condition { get; set; }
    }

    public class Data
    {
        public Essentials essentials { get; set; }
        public AlertContext alertContext { get; set; }
    }
    

    //public class CommonAlertSchemaModel
    //{
    //    public Properties properties { get; set; }
    //    public string location { get; set; }
    //    public Tags tags { get; set; }
    //}
    //public class EmailReceiver
    //{
    //    public string name { get; set; }
    //    public string emailAddress { get; set; }
    //    public bool useCommonAlertSchema { get; set; }
    //}

    //public class SmsReceiver
    //{
    //    public string name { get; set; }
    //    public string countryCode { get; set; }
    //    public string phoneNumber { get; set; }
    //}

    //public class WebhookReceiver
    //{
    //    public string name { get; set; }
    //    public string serviceUri { get; set; }
    //    public bool useCommonAlertSchema { get; set; }
    //}

    //public class Properties
    //{
    //    public string groupShortName { get; set; }
    //    public bool enabled { get; set; }
    //    public List<EmailReceiver> emailReceivers { get; set; }
    //    public List<SmsReceiver> smsReceivers { get; set; }
    //    public List<WebhookReceiver> webhookReceivers { get; set; }
    //}

    //public class Tags
    //{
    //}
}

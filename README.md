# appinsights2022
AI demo

sample changes

            var telemetryClient = new TelemetryClient();
            telemetryClient.InstrumentationKey = "489af2eb-1136-4abb-a779-9a56be206db7";

            telemetryClient.TrackEvent("This is a test event");
            telemetryClient.TrackMetric("Test Metric", 777);
            telemetryClient.TrackTrace("Test Trace Message", Microsoft.ApplicationInsights.DataContracts.SeverityLevel.Information);

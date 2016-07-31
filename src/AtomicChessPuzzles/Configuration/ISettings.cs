﻿namespace AtomicChessPuzzles.Configuration
{
    public interface ISettings
    {
        MongoSettings Mongo { get; set; }
        int TimedTrainingSessionAutoAcknowledgerDelay { get; set; }
    }
}

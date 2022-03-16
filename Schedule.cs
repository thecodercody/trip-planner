using System;
using Itenso.TimePeriod;

class Schedule {
    public TimePeriodCollection timeline { get; set; } = new TimePeriodCollection();

    public void add(Flight flight) {
        TimeRange timeRange = new TimeRange(flight.depTime, flight.arrTime);
        timeline.Add(timeRange);
    }

    public void add(Hotel hotel) {

    }

    public DateTime start() {
        return timeline.Start;
    }

    public DateTime end() {
        return timeline.End;
    }

    
}
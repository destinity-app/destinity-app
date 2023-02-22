namespace Destinity.Components.Event; 

public class EventData {
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public CalendarData? CalendarData { get; set; }

	public List<Attendee> Attendees { get; set; } = default!;
}

public class Attendee {
	public Guid Id { get; set; }
	public required string Nickname { get; set; }
}
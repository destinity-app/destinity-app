using Destinity.Components.Event;

namespace Destinity.Components.EventResult; 

public class EventResultData {
	public Guid Id { get; set; }
	public required string Name { get; set; }
	public required CalendarData CalendarData { get; set; }

	public List<Attendee> Attendees { get; set; } = default!;
}
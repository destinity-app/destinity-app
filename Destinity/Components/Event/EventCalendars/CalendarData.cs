namespace Destinity.Components.Event.EventCalendars; 

public class CalendarData {
	public List<DayData> Days { get; init; } = new();
}

public class DayData {
	public DateOnly Date { get; init; }
	public List<SlotData> Slots { get; init; } = new();
}

public class SlotData {
	public TimeOnly Start { get; set; }
	public TimeOnly End { get; set; }
	public List<Answer> Answers { get; set; } = new();
}

public class Answer {
	public Guid AttendeeId { get; set; }
	public AnswerStatus Status { get; set; }
}

public enum AnswerStatus {
	Unknown,
	Accepted,
	Rejected,
	OnlyIfNeeded
}
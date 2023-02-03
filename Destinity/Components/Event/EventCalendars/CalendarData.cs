namespace Destinity.Components.Event.EventCalendars; 

public class CalendarData {
	public List<DateData> Days { get; init; } = new();
}

public class DateData {
	public DateOnly Date { get; init; }

	public Dictionary<int, Answer> Answers { get; set; } = new();
}

public class Answer {
	public Guid AttendeId { get; set; }
	public AnswerStatus Status { get; set; }
}

public enum AnswerStatus {
	Unknown,
	Accepted,
	Rejected,
	OnlyIfNeeded
}
using Destinity.Components.Event;
using Destinity.Components.EventResult;

namespace Destinity.Data;

public class TestData {
	public static EventResultData EventResultData => new() {
		Id = Guid.Empty,
		Name = "Sesja RPG",
		CalendarData = new CalendarData {
			Days = {
				new DayData {
					Date = DateOnly.FromDateTime(DateTime.Now),
					Slots = new List<SlotData> {
						new() {
							Start = new TimeOnly(7, 0, 0),
							End = new TimeOnly(8, 0, 0),
							Answers = new List<Answer> {
								new() {
									Status = AnswerStatus.Rejected,
									AttendeeId = Guid.Parse("751F4E15-EBCD-4610-8390-B753DEF17910")
								}
							}
						},
						new() {
							Start = new TimeOnly(8, 0, 0),
							End = new TimeOnly(9, 0, 0),
							Answers = new List<Answer> {
								new() {
									Status = AnswerStatus.Accepted,
									AttendeeId = Guid.Parse("751F4E15-EBCD-4610-8390-B753DEF17910")
								}
							}
						}
					}
				},
				new DayData {
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1))
				},
				new DayData {
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2))
				},
				new DayData {
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3))
				},
				new DayData {
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4))
				},
				new DayData {
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5))
				},
				new DayData {
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(6))
				}
			}
		},
		Attendees = new List<Attendee> {
			new() {
				Id = Guid.Parse("751F4E15-EBCD-4610-8390-B753DEF17910"),
				Nickname = "Hubert"
			},
			new() {
				Id = Guid.Parse("30A42D89-A2B8-4545-8424-9E6897A33B43"),
				Nickname = "Maciej"
			},
			new() {
				Id = Guid.Parse("61057381-81F5-4D44-93BE-57E04632D7F2"),
				Nickname = "Kasia"
			},
			new() {
				Id = Guid.Parse("6FF930D1-9592-4FAC-85BF-1DA20E806F33"),
				Nickname = "Krysia"
			},
			new() {
				Id = Guid.Parse("F5C1E2F9-C790-4753-9230-B38EFDCAD8BF"),
				Nickname = "Zosia"
			}
		}
	};
}
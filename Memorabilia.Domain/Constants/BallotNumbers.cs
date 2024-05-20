namespace Memorabilia.Domain.Constants;

public sealed class BallotNumbers : DomainItemConstants
{
    public static readonly BallotNumbers Eighth = new(8, "8th");
    public static readonly BallotNumbers Eleventh = new(11, "11th");
    public static readonly BallotNumbers Fifth = new(5, "5th");
    public static readonly BallotNumbers Fifthteenth = new(15, "15th");
    public static readonly BallotNumbers First = new(1, "1st");
    public static readonly BallotNumbers Fourth = new(4, "4th");
    public static readonly BallotNumbers Fourteenth = new(14, "14th");
    public static readonly BallotNumbers Nineth = new(9, "9th");
    public static readonly BallotNumbers Second = new(2, "2nd");
    public static readonly BallotNumbers Seventh = new(7, "7th");
    public static readonly BallotNumbers Sixteenth = new(16, "16th");
    public static readonly BallotNumbers Sixth = new(6, "6th");
    public static readonly BallotNumbers Tenth = new(10, "10th");
    public static readonly BallotNumbers Third = new(3, "3rd");
    public static readonly BallotNumbers Thirteenth = new(13, "13th");
    public static readonly BallotNumbers Twelveth = new(12, "12th");

    public static readonly BallotNumbers[] All =
    [
        First,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth,
        Seventh,
        Eighth,
        Nineth,
        Tenth,
        Eleventh,
        Twelveth,
        Thirteenth,
        Fourteenth,
        Fifthteenth,
        Sixteenth
    ];

    private BallotNumbers(int id, string name) 
        : base(id, name) { }

    public static BallotNumbers Find(int id)
        => All.SingleOrDefault(ballotNumber => ballotNumber.Id == id);
}

namespace DevService.Domain.Questions;

public class Answer
{
    /*public Answer(Guid userId, string text, Question question)
    {
        UserId =  userId;
        Text = text;
        Question = question;
    }*/
    public Guid Id { get; set; }
    
    public required Guid UserId { get; set; }
    
    public required string Text { get; set; } = string.Empty;
    
    public required Question Question { get; set; }
    
    public List<Guid> Tags { get; set; } = [];
}
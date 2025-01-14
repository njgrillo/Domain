﻿namespace Memorabilia.Domain.Entities;

public class Personalization : Entity
{
    public Personalization() { }

    public Personalization(int autographId, string text)
    {
        AutographId = autographId;
        Text = text;
    }

    public int AutographId { get; private set; }

    public string Text { get; private set; }

    public void Set(string text)
    {
        Text = text;
    }
}

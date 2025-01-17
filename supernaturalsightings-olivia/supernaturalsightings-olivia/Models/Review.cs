﻿using Microsoft.CodeAnalysis;
using System.Xml.Linq;


namespace supernaturalsightings_olivia.Models;

public class Review : Entity
{
    //Changed Id to EntityId -Tanya
    public int EntityId { get; set; }
    // static private int nextId = 1;
    //State from Entity
    public int ReviewId { get; set; } 
    public string DisplayName { get; set; } = "";
    public string ReviewTitle { get; set; } = "";
    public string ReviewComment { get; set; } = "";
    public int Rating { get; set; }
    // public int ReviewId { get; set; } //
    //  public ReviewCategory ReviewCategory { get; set; } //coreCompetency

    public Review()
    {

    }
    public Review(int id, string displayName, string reviewTitle, string reviewComment, int rating) : this() //ReviewCategory newReviewCategory
    {
        ReviewId = id;
        DisplayName = displayName;
        ReviewTitle = reviewTitle;
        ReviewComment = reviewComment;
        Rating = rating;
        //  ReviewCategory = newReviewCategory;

    }

    public override string ToString()
    {
        string output = " ";
        if (DisplayName.Equals(" "))
        {
            DisplayName = "Data not available";

        }
        // if (ReviewCategory.Value.Equals("") || ReviewCategory.Value == null)
        // {
        //     ReviewCategory.Value = "Data not available";


        output = string.Format("\nID: %d\n" +
                "Display Name: %s\n" +
                "Review Title: %s\n" +
                "Review Comment: %s\n" +
                "Rating: %s\n" + ReviewId, DisplayName, ReviewTitle, ReviewComment, Rating);// ReviewCategory);
        return output;
    }

    public override bool Equals(object? obj)
    {
        return obj is Review review &&
               ReviewId == review.ReviewId;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ReviewId);
    }

}
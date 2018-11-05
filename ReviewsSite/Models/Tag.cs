using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Text { get;set; }

        // One last tricky thing here:
        // If we try to serialize a tag into JSON, here's what happens:
        // We see a list of review tags on the tag.  we try to serialize them.
        // Each tag has a List<ReviewTag> which brings us back over here in the tag.
        // the tag has ReviewTags, which have tags, which have review tags
        // over and over forever.  We can stop that from happening by telling it not to serialize this
        // property: so this ignore is stopping it from jumping back and forth  yup!  forever.  it would eventually 
        //overflow.  That's actually what a "StackOverflow" is :)
        // I think our models look ok.  Let's do some migrations and update database if it all builds.'
        [JsonIgnore] // using this handy tag.
        public virtual List<ReviewTag> ReviewTags { get; set; } //so even with many to many there still need to be 
        //an intermediary that connects 
        // Yup.  One to many you don't need it, but many to many you need it.  One to many you wind up with a
        // List<OtherThing> on one entity, and OtherThing has a `int FirstThingId` on it.
        //ahhhh i see i thought we didnt need it .whoops ;)ok now check all my other mess  loli click my 
//  initials up top right to follow me around.
        // ^ perfect
        // Go ahead and create a ReviewTag class (it won't let me do it) in the models folder
      
    }//is this how you even set it up ? kayti said i was doing this all wrong 
    /*
        You need to make this a many to many between the tag and the reviews.  So you'll need that
        third class (ReviewTag) that sits between the review and the tag.  Something like this:
        public virtual List<ReviewTag> ReviewTags {get; set;}
        Then the ReviewTag should look something like this:
        public int ReviewId {get; set;}
        public int TagId {get; set;}
        plus the navigation properties tagged as virtual.
        Right now each tag can only have one review.
        hmmm, also, no need for the category stuff in this class.

        Maybe we get the models sorted out first and then go from there?  What do you think?
        
        haha  ;)
    */
}

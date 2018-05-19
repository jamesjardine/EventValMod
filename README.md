# EventValMod
This tool was generated to provide a proof of concept on manipulating Event Validation in a .Net application.  It is a simple forms application built in c#. There are many limitations and this will not work on any current .Net installaments.

Event Validation cannot be modified if ViewStateMac is enabled. Microsoft made a change a few years ago that disabled the ability to turn this off. 

Event Validation can be deserialized in versions prior to .Net 4.0. If successful, you should see a list of negative integers.

Event Validation changed in .Net 4.0 to use a custom internal class as its storage mechanism. This leads to an InvalidCastException.

Event Validation changed in .Net 4.5+ to default to encrypting the resulting data. This makes it impractical to deserialize.

For a much more detailed description of this issue (for educational purposes) check out https://www.jardinesoftware.net/2012/02/06/asp-net-tampering-with-event-validation-part-1/

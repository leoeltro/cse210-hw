using System;

class Program
{
	static int numberComments = 0;
	static void Main(string[] args)
	{

		Console.Clear();
		Console.WriteLine("Hello World! This is the YouTubeVideos Project."); Console.WriteLine();

		string _title = "Introduction to C#";
		string _author = "John Doe";
		string _durationVideo = "10:00";
		


		//VIDEO 01 -------------------------------------------------------------------------------------
		String commentary = "";
		string name = "";


		// Create comments part 01
		commentary = "Great video!";
		name = "Alice";
		Comments _comment01 = new Comments(name, commentary);


		// Create comments part 02
		commentary = "Very informative.";
		name = "Bob";
		Comments _comment02 = new Comments(name, commentary);


		// Create comments part 03
		commentary = "I learned a lot.";
		name = "Charlie";
		Comments _comment03 = new Comments(name, commentary);


		// Create comments part 04
		commentary = "Amazing content!";
		name = "David";
		Comments _comment04 = new Comments(name, commentary);


		Video _video1 = new Video(_title, _author, _durationVideo);// Create a video INITIALIEZED

		// Add EACH comments to the video 01
		_video1._comments.Add(_comment01);
		_video1._comments.Add(_comment02);
		_video1._comments.Add(_comment03);
		_video1._comments.Add(_comment04);


		Console.WriteLine("-------------------------------------------------------------------------------------");
		_video1.DisplayVideoInformation();
		numberComments = _video1.ShowComments();
		Console.WriteLine($"Number of Comments: {numberComments}");
		Console.WriteLine("-------------------------------------------------------------------------------------");






		//VIDEO 02-------------------------------------------------------------------------------------

		_title = "The life of John#";
		_author = "Marie Clare";
		_durationVideo = "11:35";
		Video _video2 = new Video(_title, _author, _durationVideo);// Create a video INITIALIEZED


		commentary = "Tel me about the video!";
		name = "Alisson";
		Comments _commentUnique1 = new Comments(name, commentary);
		_video2._comments.Add(_commentUnique1);


		commentary = "Hi we will go to see the video!";
		name = "Leonardo";
		Comments _commentUnique2 = new Comments(name, commentary);
		_video2._comments.Add(_commentUnique2);


		commentary = "Today I expect to repeat the video!";
		name = "Caroline";
		Comments _commentUnique3 = new Comments(name, commentary);
		_video2._comments.Add(_commentUnique3);


		Console.WriteLine("-------------------------------------------------------------------------------------");
		_video2.DisplayVideoInformation();
		numberComments = _video2.ShowComments();
		Console.WriteLine($"Number of Comments: {numberComments}");
		Console.WriteLine("-------------------------------------------------------------------------------------");




		//VIDEO 03/-------------------------------------------------------------------------------------

		_title = "The Inesquecible Life";
		_author = "Ariel Goulart";
		_durationVideo = "09:22";
		Video _video3 = new Video(_title, _author, _durationVideo);// Create a video INITIALIEZED


		// Create comments part 01
		commentary = "How fast are going the lite!";
		name = "Perla Carl";
		Comments _comment01Video3 = new Comments(name, commentary);
		_video3._comments.Add(_comment01Video3);


		commentary = "I loved to see the this video!";
		name = "Aline Couvet";
		Comments _comment02Video3 = new Comments(name, commentary);
		_video3._comments.Add(_comment02Video3);


		commentary = "It is my better thing I watch today!";
		name = "fernandine catarine";
		Comments _comment03Video3 = new Comments(name, commentary);
		_video3._comments.Add(_comment03Video3);


		Console.WriteLine("-------------------------------------------------------------------------------------");
		_video3.DisplayVideoInformation();
		numberComments = _video3.ShowComments();
		Console.WriteLine($"Number of Comments: {numberComments}");
		Console.WriteLine("-------------------------------------------------------------------------------------");

	}
}

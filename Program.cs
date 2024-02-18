using System;
using System.Speech.Synthesis;

namespace SampleSynthesis
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.
            //synth.SetOutputToDefaultAudioDevice();

            // Set the voice
            //synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synth.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Child);
            // Speak a string.
            //synth.Speak("This example demonstrates a basic use of Speech Synthesizer");
            synth.Speak("Hi! I'm Banti Rawat From Uttar Pradesh.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
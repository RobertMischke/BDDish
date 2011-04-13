using System;
using System.Collections.Generic;
using BDDish.Model.Visualizer;
using BDDish.Model;

namespace BDDish
{
    public class ConsoleWriter
    {
        private const string NoteIndent = " ";
        private const string IndentUserStory = " ";
        private const string IndentCustomer = " ";
        private const string IndentAceptanceCriteria = "    ";
        private const string IndentContext = "      ";
        private const string IndentContextSetting = "        ";
        private const string IndentAssertion = "      ";

        private readonly AssertionActionToString _assertionActionToString = new AssertionActionToString();

        public void Write(Feature feature)
        {
            Console.WriteLine(feature.Label);
            WriteNotes(feature.Notes, indent: NoteIndent);

            if (feature.FeatureDesription != null)
            {
                Console.WriteLine(" " + feature.FeatureDesription.Label);
                WriteNotes(feature.FeatureDesription.Notes, indent: " " + NoteIndent);
            }

            WriteUserStoryInfo(feature);            
        }


        private void WriteUserStoryInfo(Feature feature)
        {
            foreach (var userStory in feature.UserStories)
            {
                Console.WriteLine(IndentUserStory + userStory.Label);
                WriteNotes(userStory.Notes, indent: IndentUserStory + NoteIndent);
                WriteCustomerInfo(userStory);
            }
        }

        private void WriteCustomerInfo(UserStory userStory)
        {
            foreach (var customer in userStory.Customers)
            {
                Console.WriteLine(IndentCustomer + customer.Label);
                WriteNotes(customer.Notes, indent: IndentCustomer + NoteIndent);
                WriteAcceptanceInfo(customer);
            }
        }

        private void WriteAcceptanceInfo(Customer customer)
        {
            foreach (var acceptanceCriterion in customer.AcceptanceCriteria)
            {
                Console.WriteLine(IndentAceptanceCriteria + acceptanceCriterion.Label);
                WriteNotes(acceptanceCriterion.Notes, indent: IndentAceptanceCriteria + NoteIndent);
                
                if (!acceptanceCriterion.IsDraft)
                {
                    if (acceptanceCriterion.HasContext)
                    {
                        Console.WriteLine(IndentContext + acceptanceCriterion.Context.Label);
                        WriteNotes(acceptanceCriterion.Context.Notes, indent: IndentContext + NoteIndent);

                        foreach(var contextInfo in acceptanceCriterion.Context.Settings)
                            Console.WriteLine(IndentContextSetting + contextInfo.Label + _assertionActionToString.GetString(contextInfo.Action));

                    }
                        
                    WriteAssertionInfo(acceptanceCriterion);    
                }
                
            }
        }

        private void WriteAssertionInfo(AcceptanceCriterion acceptanceCriterion)
        {
            foreach (var assertion in acceptanceCriterion.GetAllAssertions())
            {
                Console.WriteLine(IndentAssertion + assertion.LabelConcept + ": " + _assertionActionToString.GetString(assertion.Action));
                WriteNotes(assertion.Notes, indent: IndentAssertion + NoteIndent);
            }
                
        }

        private static void WriteNotes(IEnumerable<Note> notes, string indent)
        {
            foreach (var note in notes)
                Console.WriteLine(indent + note.Label);
        }
    }
}
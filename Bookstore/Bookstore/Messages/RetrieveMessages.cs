using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Classes;

namespace Bookstore.Messages
{
    class RetrieveMessages
    {

        public static Dictionary<int, List<Message>> retrieveUserMessages(String username)
        {
            /*
             * Receives a string with the username of logged user and uses this username to search in the database for their messages
             * All the messages are collected in a list and then sorted based on time sent
             */


            List<Message> messages = Database.getUserConversations(username);
            Dictionary<int, List<Message>> messages_categorized = categorizeMessagesByQuestionID(messages);

            //messages_categorized = messages_categorized.OrderBy(f => f.Count ).ToList(); // sort the messages based on the questions that have been answered

            return messages_categorized;
        }





        static Dictionary<int, List<Message>> categorizeMessagesByQuestionID( List<Message> messages)
        {
            /*
             *  Gets a list of messages that belong to a speicific user and categorizes them based on the QuestionID
             */

            Dictionary<int, List<Message>> categorizedMessagesDict = new Dictionary<int, List<Message>>();
            foreach( Message m in messages)
            {
                
                if (!categorizedMessagesDict.ContainsKey(m.QuestionID)){
                    categorizedMessagesDict.Add(m.QuestionID, new List<Message>());
                }
                categorizedMessagesDict[m.QuestionID].Add(m);
            }

            return categorizedMessagesDict;
        }


        

    }
}

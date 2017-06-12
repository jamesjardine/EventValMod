using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Util;
using System.Runtime.InteropServices;
using System.Web.UI;

namespace JSI.SecurityTools.EventValidationHandler
{
    public class EventValidationHandler
    {

        public static ArrayList DeserializeFrom(System.IO.Stream inputStream)
        {
            ArrayList store = new ArrayList();
            DeserializingBinaryReader reader = new DeserializingBinaryReader(inputStream);
            if (reader.ReadByte() != 0)
            {
                Console.WriteLine("Error");
            }
            int num2 = reader.Read7BitEncodedInt();
            for(int i = 0;i < num2;i++)
            {
                byte[] item = reader.ReadBytes(0x10);
                if (item.Length != 0x10)
                {
                    Console.WriteLine("Error");
                }
                store.Add(System.Text.Encoding.UTF8.GetString(item));
            }
            return store;
        }

        /// <summary>
        /// Deserializes the __EVENTVALIDATION value found in the html hidden field to an 
        /// array list which can then be manipulated.
        /// </summary>
        /// <param name="eventValidation"></param>
        /// <returns></returns>
        public static ArrayList DeSerializeStringToArray(string eventValidation)
        {
            ObjectStateFormatter _formatter = new ObjectStateFormatter();
            return (ArrayList)_formatter.Deserialize(eventValidation);
        }
        public static ArrayList DeSerializeStringToArray2(string eventValidation)
        {
            ObjectStateFormatter _formatter = new ObjectStateFormatter();
            string test = _formatter.Deserialize(eventValidation).ToString();
            Console.WriteLine(test);
            return new ArrayList();
        }

        /// <summary>
        /// Serialized an array list of hash codes back to the string used for __EVENTVALIDATION.
        /// </summary>
        /// <param name="arrayList"></param>
        /// <returns></returns>
        public static string SerializeArrayToString(ArrayList arrayList)
        {
            ObjectStateFormatter _formatter = new ObjectStateFormatter();
            return _formatter.Serialize(arrayList);
        }

        /// <summary>
        /// This method calculates the hash value that gets stored in the __EVENTVALIDATION 
        /// hidden field array.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetStringHashCodeValue(string s)
        {
            return GetStringHashCode(s);
        }

        /// <summary>
        /// This method calculates the hash value that gets stored in the __EVENTVALIDATION 
        /// hidden field array.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        internal static unsafe int GetStringHashCode(string s)
        {
            fixed (char* str = s)
            {
                char* chPtr = str;
                int num = 0x15051505;
                int num2 = num;
                int* numPtr = (int*)chPtr;
                for (int i = s.Length; i > 0; i -= 4)
                {
                    num = (((num << 5) + num) + (num >> 0x1b)) ^ numPtr[0];
                    if (i <= 2)
                    {
                        break;
                    }
                    num2 = (((num2 << 5) + num2) + (num2 >> 0x1b)) ^ numPtr[1];
                    numPtr += 2;
                }
                return (num + (num2 * 0x5d588b65));
            }
        }
    }
}

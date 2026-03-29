using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace Assignment3
{
    /// <summary>
    /// A generic class that manages a list of objects of type T.
    /// </summary>
    /// <typeparam name="T">The type of items to store in the list.</typeparam>
    public class ListManager<T> : IListManager<T>
    {
        // The internal collection used to store the items
        private List<T> m_list;

        /// <summary>
        /// Constructor initializes the internal list.
        /// </summary>
        public ListManager()
        {
            m_list = new List<T>();
        }

        /// <summary>
        /// Gets the number of items currently in the list.
        /// </summary>
        public int Count
        {
            get { return m_list.Count; }
        }

        /// <summary>
        /// Adds an item to the list. Validates that the item is not null.
        /// </summary>
        public bool Add(T aType)
        {
            if (aType == null)
            {
                return false;
            }

            m_list.Add(aType);
            return true;
        }

        /// <summary>
        /// Checks if the provided index is within the valid bounds of the list.
        /// </summary>
        public bool CheckIndex(int index)
        {
            return (index >= 0 && index < m_list.Count);
        }

        /// <summary>
        /// Replaces the item at the specified index. Validates the index and the new item.
        /// </summary>
        public bool ChangeAt(T aType, int anIndex)
        {
            if (aType != null && CheckIndex(anIndex))
            {
                m_list[anIndex] = aType;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Clears all items from the list.
        /// </summary>
        public void DeleteAll()
        {
            m_list.Clear();
        }

        /// <summary>
        /// Removes the item at the specified index. Validates the index first.
        /// </summary>
        public bool DeleteAt(int anIndex)
        {
            if (CheckIndex(anIndex))
            {
                m_list.RemoveAt(anIndex);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieves the item at the specified index. 
        /// Returns the default value for type T (usually null) if the index is invalid.
        /// </summary>
        public T GetAt(int anIndex)
        {
            if (CheckIndex(anIndex))
            {
                return m_list[anIndex];
            }
            return default(T); // Returns null for reference types
        }

        /// <summary>
        /// Converts the collection into an array of strings using each item's ToString() method.
        /// </summary>
        public string[] ToStringArray()
        {
            string[] strArray = new string[m_list.Count];
            for (int i = 0; i < m_list.Count; i++)
            {
                // We use ?. to handle any unexpected nulls gracefully
                strArray[i] = m_list[i]?.ToString();
            }
            return strArray;
        }

        /// <summary>
        /// Converts the collection into a list of strings using each item's ToString() method.
        /// </summary>
        public List<string> ToStringList()
        {
            List<string> strList = new List<string>();
            foreach (T item in m_list)
            {
                strList.Add(item?.ToString());
            }
            return strList;
        }

        public void SaveToJson(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                // NOTE: If you still get an error here, change m_list to whatever you named your List<T> at the top of this file!
                string jsonString = JsonSerializer.Serialize(m_list, options);
                writer.Write(jsonString);
            }
        }

        public void LoadFromJson(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string jsonString = reader.ReadToEnd();
                m_list = JsonSerializer.Deserialize<List<T>>(jsonString);
            }
        }

        public virtual void SaveToText(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (T item in m_list)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        public virtual void LoadFromText(string fileName)
        {
            m_list.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // To do: Add parsing logic to reconstruct objects from the text line
                }
            }
        }
    }
}

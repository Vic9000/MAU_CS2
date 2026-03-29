using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Assignment3
{
    /// <summary>
    /// Defines a generic interface to manage lists.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    public interface IListManager<T>
    {
        /// <summary>
        /// Gets the current number of items in the list.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds a new item to the end of the list.
        /// </summary>
        /// <param name="aType">The item to add.</param>
        /// <returns>True if the addition was successful, otherwise false.</returns>
        bool Add(T aType);

        /// <summary>
        /// Replaces an existing item at the specified index with a new item.
        /// </summary>
        /// <param name="aType">The new item to insert.</param>
        /// <param name="anIndex">The index of the item to replace.</param>
        /// <returns>True if the change was successful, otherwise false.</returns>
        bool ChangeAt(T aType, int anIndex);

        /// <summary>
        /// Validates whether the provided index is within the bounds of the list.
        /// </summary>
        /// <param name="index">The index to check.</param>
        /// <returns>True if the index is valid, otherwise false.</returns>
        bool CheckIndex(int index);

        /// <summary>
        /// Removes all items from the list.
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Removes the item at the specified index.
        /// </summary>
        /// <param name="anIndex">The index of the item to remove.</param>
        /// <returns>True if the deletion was successful, otherwise false.</returns>
        bool DeleteAt(int anIndex);

        /// <summary>
        /// Retrieves the item at the specified index without removing it.
        /// </summary>
        /// <param name="anIndex">The index of the item to retrieve.</param>
        /// <returns>The item of type T at the specified index.</returns>
        T GetAt(int anIndex);

        /// <summary>
        /// Converts the collection into an array of strings.
        /// </summary>
        /// <returns>A string array where each element represents an item in the list.</returns>
        string[] ToStringArray();

        /// <summary>
        /// Converts the collection into a list of strings.
        /// </summary>
        /// <returns>A List of strings where each element represents an item in the list.</returns>
        List<string> ToStringList();

        /// <summary>
        /// Serializes the current list of items and saves them to a JSON file.
        /// </summary>
        /// <param name="fileName">The file path where the JSON data will be saved.</param>
        void SaveToJson(string fileName);

        /// <summary>
        /// Reads a JSON file, deserializes the contents, and replaces the current list with the loaded items.
        /// </summary>
        /// <param name="fileName">The file path of the JSON data to load.</param>
        void LoadFromJson(string fileName);

        /// <summary>
        /// Saves the string representation of each item in the list to a plain text file, row by row.
        /// </summary>
        /// <param name="fileName">The file path where the text data will be saved.</param>
        void SaveToText(string fileName);

        /// <summary>
        /// Reads a plain text file line by line and reconstructs the list of items.
        /// </summary>
        /// <param name="fileName">The file path of the text data to load.</param>
        void LoadFromText(string fileName);
    }
}

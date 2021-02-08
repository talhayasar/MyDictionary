using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] itemkey;
        TValue[] itemvalue;
        public MyDictionary() //constructor method
        {
            itemkey = new TKey[0];// zero element itemkey array
            itemvalue = new TValue[0];//zero element itemvalue array
        }
        public void Add(TKey key, TValue value)//Add method is going to add new key and value to MyDictionary object.
        {
            TKey[] tempkey = itemkey;//temporary array in order not to lose old keys
            TValue[] tempvalue = itemvalue;//temporary array in order not to lose old values
            itemkey = new TKey[itemkey.Length + 1];//creating itemkey again with one more length
            itemvalue = new TValue[itemvalue.Length + 1];//creating itemvalue again with one more length
            for (int i = 0; i < tempkey.Length; i++)//when new itemkey ans itemvalue crated, old data is deleted
                                                    //because new creates new adress to this variables.
                                                    //to assign this old data to the new, temparrays are created
                                                    //and with for loop assigned to new adress
            {
                itemkey[i] = tempkey[i];
            }
            for (int i = 0; i < tempvalue.Length; i++)
            {
                itemvalue[i] = tempvalue[i];
            }
            itemkey[itemkey.Length - 1] = key;//with that the last(means the added element) added to the itemkey
            itemvalue[itemvalue.Length - 1] = value;//with that the last(means the added element) added to the itemvalue
        }
        public TValue[] Items//for printing to console
        {
            get { return itemvalue; }

        }

    }
}
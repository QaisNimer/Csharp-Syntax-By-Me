List<int> numbers = new List<int>();
int[] arr = new int[10];
Array.Fill(arr, new Random().Next(1, 81));
for (int i = 0; i < 10; i++)
{
    numbers.Add(new Random().Next(1, 81));
}
//Fillteration 
numbers.Where(x => x % 3 == 0); //return IEmunurable of elements that matched the condition  
numbers.Any(x => x == 17); //return bool value to determine if there any value matched the given condition
numbers.Find(x => x == 5); // reuturn the first element that matched the condition otherwise return the deafult of selected data type 
numbers.Distinct();//return the given list with out dublicate
numbers.DistinctBy(x => x);//reutrn the given list after /fillter depends on the given key (property)

//Ordering - Sorting
numbers.Order();//return element in asending order
numbers.OrderBy(x => x);//return element in asending order depends on given key / property , LIST OF OBJECTS
numbers.OrderDescending();//return element in desinging order
numbers.OrderByDescending(x => x); //return element in desinging order depends on given key / property

//Selecation 
//Exttract Colleaction 
arr.ToList(); // convert the given dataset to List of the same type 
numbers.ToArray(); //convert the given dataset to Array of the same type 
int t = 0;
arr.ToDictionary(x => $"Key {t++}"); //convert the given dataset to Dictionry with value  of the same type but you need to pass the key 

//Get - Extract One Eelemnt 
numbers.First(); // return the first element of the given collection - error (sequence contains no element)
numbers.FirstOrDefault();// return the first element of the given collection - the default value of given collection 
numbers.Single();//return the only one existing element on collection - error (sequence contains no element) - - error (sequence contains more than one  element)
numbers.SingleOrDefault(); //return the only one existing element on collection  - error(sequence contains more than one  element)
numbers.Last();// return the last element of the given collection - error (sequence contains no element)
numbers.LastOrDefault();// return the last element of the given collection - the default value of given collection 

//Aggeragtion Selection
numbers.Count(); // the number of element in given collecation 
numbers.Sum(); // return the summation of all element in given numeric collection 
numbers.Average();// return the aggregation of all element in given numeric collection 
numbers.Max();//return the maximum value in collecation
numbers.Min();//return the minumum value in colleaction

//Pagianation Selection 
numbers.Take(5); // get at maximum the first top  5 element in collection 
numbers.TakeLast(5); // get at maximum the last 5 element in collection 
numbers.TakeWhile(x => x % 3 == 0);//get element depends on given condition 

numbers.Skip(5); // ignore at maximum the first top  5 element in collection 
numbers.SkipLast(5); // ignore at maximum the last 5 element in collection 
numbers.SkipWhile(x => x % 3 == 0);//ignore element depends on given condition 
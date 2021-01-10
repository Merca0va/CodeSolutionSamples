using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;


namespace RealLifeExemples_2
{
   class Program
   {
		public static string Longest(string s1, string s2)
		{
			string s3 = s1 + s2;

			return string.Concat((s3).Distinct().OrderBy(c => c)); // Reform the string by making any char appear only once.
		}

		public static string SpinWords(string sentence)  // Reverse all letters's position of a word.
		{

			char[] words = sentence.ToCharArray();

			Array.Reverse(words);

			return new string(sentence);     


		}

		public static int NextId(int[] ids)  // return the smallest unused data
		{
			int i = 0;

			while (ids.Contains(i))
			{
				i++;
			}

			return i;     
		}


		public static bool IsIsogram(string str)  // Check if a string has repeating chars, consecutive or non consecutively;
		{
			return str.Length == new HashSet<char>(str.ToLower()).Count; 

		}


		public static int ModifiedSum(int[] a, int n)  // For the given array, we calculate the sum of each value to the n-th power. Then subtract the sum of the original array.
		{
			return a.Sum(x => (int)Math.Pow(x, n) - x); 
		}


		public static int NbYear(int p0, double percent, int aug, int p)  // In a small town the population is p0 at the beginning of a year. The population regularly increases by 2 percent per year and moreover aug new inhabitants per year come to live in the town. It returns how many years the town need to see its population greater or equal to p inhabitants.
		{
			int year;
			for (year = 0; p0 < p; year++)
				p0 += (int)(p0 * percent / 100) + aug;
			return year;     
		}


		public static string IsEvenOrOdd(int num)  // Check if an int is odd or even;
		{
			if ((num % 2) == 0)   
			{
				return "even";
			}
			else
			{
				return "odd";
			}
		}

		public static int AddUp(int num)  // Add up all the numbers from 1 to the number int num passed to the function. For example, if the input is 4 then your function should return 10 because 1 + 2 + 3 + 4 = 10.
		{                                 //  or can be the same as   {
			int i = 1;                                         //  return (num*(num+1))/2;
			int sum = 0;                                       // }
			while (i <= num)             
			{                             
				sum += i;             
				i++;                  
			}
			return sum;
		}

		public static double Index(int[] array, int n)  //  Given an array with positive numbers and a number n It create a function that find the N-th power of the element in the array with the index N. If n is outside of the array, then return -1.
		{
			for (int i = 0; i < array.Length; i++)    
			{
				if (i == n)
				{
					return Math.Pow(array[i], n);
				}
			}
			return -1;
		}

		public static int NumberSyllables(string word)  // Create a function that counts the number of syllables a word has when each syllable is separated with a dash.
		{
			return word.Split('-').Length;     
		}

		public static bool EqualSlices(int total, int people, int each)  // return true if a total of slice with be equal to the total of slice per person sharing the same pizza.
		{
			if (people * each <= total)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static int CharCount(char myChar, string str)  // Counting how many char mychar contains the string str.
		{                                                     // or {                                                               or else   {

			int count = str.Split(myChar).Length - 1;         //    int newCount = str.Replace(myChar.ToString(),"").Length;                  int count = 0;
															                  //
			return count;                                     //    return str.Length - newCount;                                             foreach (char letter in str)
															                  //               {
		}                                                         // }                                                                              if (letter == myChar)
															                  //                   {   
															                  //                       count++;
															                  //                   }    
															                  //               }
															                  //                 
															                  //              return count;
															                  //                           
															                  //                         
															                  //          }
															                  //

		public static int FindIndex(string[] arr, string str)   // Gives the index of a string str contained inside an array arr.
		{                                          //  Or {
								//
			int x;                                 //      int x = 0;
							       //
			x = Array.IndexOf(arr, str);           //      for (int i = 0; arr.Length > i; i++)
							       //      {
			return x;                              //        if (arr[i] == str)
							       //         {
		}                                              //           x = i;
							       //         }
							       //      }
							       //         
							       //      return x;
							       //
							       //  }    
							       

		
		public static bool hurdleJump(int[] hurdles, int jumpHeight)  //Create a function that takes an array int[] hurdles and an int jumpHeight, and determine whether or not jumpHeight is greater or equal than any of hurdles value.
		{
			for (int i = 0; i < hurdles.Length; i++)          
			{
				if (hurdles[i] > jumpHeight)
				{
					return false;
				}
			}
			return true;
		}
		
		/*public static bool hurdleJump(int[] hurdles, int jumpHeight)
		{

			int bigOne = hurdles.Max();

			if (bigOne <= jumpHeight)
                         {
		           return true;                            
                         }

                       else
                       {
		          return false;
                       }
		}*/
		// This method would be normally correct but it will output an error message : System.InvalidOperationException : Sequence contains no elements
		// Instead it is preferable to use a loop as a solution to avoid that error message.
		

		public static int CountWords(string str)  // When the string is a sentence, this function returns the word count. 
		{                                                      // Or can be: {
			int count = 0;                                 //   
								       //             return str.Split().Length;
			foreach (char space in str)                    //
			{                                              //            }
				if (space == ' ')                      
				{                                      
					count++;                       
				}
			}

			return count + 1;
		}


		public static bool match(string s1, string s2)   // This function checks if two strings are identicals regardless the upper cases they might have.
		{
			if (s1.ToLower().Equals(s2.ToLower()))     
			{
				return true;
			}

			else
			{
				return false;
			}
		}

		public static int GetAbsSum(int[] arr)  // Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
		{                                                  // Or {
								   //
			return arr.Select(Math.Abs).Sum();         //      int X = 0;
								   // 
		}                                                  //      foreach(int i in arr)
								   //       {
								   //    
								   //         X = X + System.Math.Abs(i);
								   //    
								   //        }
								   //    
								   //      return X;
								   //     }


		public static string Go(int num)  // Create a function that takes a number (from 1 - 60) and returns a corresponding string of hyphens ('-').
		{                                         //     Or   {
			return new String('-', num);      //            char c = '-';
		}                                         //            string str = new string(c, num);
							  //            return str;
							  //          }
		
		           

		public static int[] MultiplyByLength(int[] arr)  // Create a function to multiply all of the values in an array by the amount of values in the given array.
		{                                 //      or {                                                    or else  {
			int X = arr.Length;             //      int X = arr.Length;                                          int X = arr.Length;
							//                                                         
			int[] arr2 = new int[X];        //      return arr.Select(i => i * X).ToArray();                     for (int i = 0; i < X; i++) 
			for (int i = 0; i < X; i++)     //    }                                                                {
			{                               //                                                                       arr[i] *= X;
						        //                                                                     }
				arr2[i] = arr[i] * X;   //                                                            
							//                                                                   return arr;         
			}                               //                                                                 }
						                                                                      
			return arr2;                                                                         
		}                    

		public static string smallerNum(string n1, string n2) // Create a function that returns the smaller number without converting it into an integer.
		{                                                             // Or  {
			if (int.Parse(n1) < int.Parse(n2))                    //        if(n1.Length < n2.Length || n1.Length == n2.Length)
			{                                                     //         {
				return n1;                                    //           return n1;
			}                                                     //         }
									      //        
			else                                                  //        else
			{                                                     //         {
				return n2;                                    //           return n2;
			}                                                     //         }
		}                                                             //      } 
             


		public static int Days(int month, int year) // Create a function that takes integers of a month and its year to return the number of days.
		{
			return DateTime.DaysInMonth(year, month);
		}		

		
		public static double[] FindMinMax(double[] values)  //Create a function that takes an array of numbers and return both the minimum and maximum numbers
		{                                                        //Or    {
			double[] X = new double[2];                      //   	   return new double[] { values.Min(), values.Max() };
			X[0] = values.Min();                             //      }
			X[1] = values.Max();
			return X;
		}

		public static int solutions(int a, int b, int c)  //A quadratic equation a x² + b x + c = 0 has either 0, 1, or 2 distinct solutions for real values of x. Given integers a, b and c, the function returns the number of solutions to the equation.
		{    
			int x = (b * b) - (4 *a  * c);      
			                               
			if (x > 0)                   
                         {                             
		           return 2;              
                         }                 
			                
			else if (x == 0)     
                         {           
		            return 1;  
                         }        
			             
			else         
                         {
		           return 0;
                         }
		}

		public static int HammingDistance(string str1, string str2) //Hamming distance is the number of characters that differ between two strings. Create a function that computes the hamming distance between two strings.
		{
			int x = 0;
			for (int i = 0; i < str1.Length; i++)
			{
				if (str1[i] != str2[i])
				{
					x++;
				}
			}
			return x;
		}

		
		public static long CalculateExponent(long number, long exponent) // Create a function that takes a base number and an exponent number and returns the calculation.
		{                                                                     // Or       {
			number = exponent;                                            //             long result = 1;
										      //
			return (long)Math.Pow(number, exponent);                      //             for (int i = 0; exponent > i; i++)
		}                                                                     //              {
										      //                 result = result * number;
										      //              }
										      //         
										      //             return result;
										      //          }
		

		public static int Factorial(int num)  // The factorial of a number is the product of all the integers from 1 to that number. Create a function that takes an integer and returns its factorial.
		{                                                       // Or   {                                     Or else {
			                                                //                         
			int fact = 1;                                   //        if(num == 1)                                  int result = num;
						                        //         {
			while (num != 1)                                //          return 1;                                    for (int i = 1; i < result; i++)
			{                                               //         }                                               {
				fact = fact * num;                      //                                                           num *= i;
				num --;                                 //        else                                             }
			}                                               //          {                                              
									//            return num * Factorial(num-1);             return result;
			return fact;                                    //          }                                             
		}                                                       //       }                                             }
		

		public static string RemoveFirstLast(string str) // Create a function that removes the first and last characters from a string.
		{
			if (str.Length <= 2)
			{
				return str;
			}
			else
			{
				return str.Substring(1, str.Length - 2);
			}
		}
		

		public static bool last_dig(int a, int b, int c) // Create a function that verifies if the last digit of (the last digit of a * the last digit of b) is equal to the last digit of c.
		{                                                    // Or   {      
			int x = a % 10;                              //        string A = a.ToString()[a.ToString().Length - 1].ToString();
			int y = b % 10;                              //        string B = b.ToString()[b.ToString().Length - 1].ToString();
			int z = c % 10;                              //        string C = c.ToString()[c.ToString().Length - 1].ToString();
						                     //        int result = Convert.ToInt32(A) * Convert.ToInt32(B);
			if (((x * y) % 10) == z)                     //     
			{                                            //        return (result.ToString()[result.ToString().Length - 1].ToString() == C);
			   return true;                              //      }
                        }           
			          
			else   
                        {   
		          return false;  
                        }
		}     

		public static int[] SortNumsAscending(int[] arr) //Create a function that takes an array of numbers and returns a new array, sorted in ascending order(smallest to biggest).
		{                                                    //  Or   {
			Array.Sort(arr);                             //          return arr.OrderBy(x=>x).ToArray();
			return arr;                                  //
		}                                                    //       }
		

		public static string NameShuffle(string str) // Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
		{                                                           //Or {
			return string.Join(" ", str.Split(' ').Reverse());  //      string[] result = str.Split(' ');
		}                                                           //      return result[1] + " " + result[0];
									    //     }

		public static bool SameCase(string str) // Create a function tat return true if a string contains only Upper characters or only lower characters.
		{
			if (str == str.ToUpper() || str == str.ToLower())
                         {
				return true;
                         }
			
                       else
                        {
				return false;
                        }
		}

		public static string HackerSpeak(string str)  //Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.
		{                                                                                                                // Or {
			return str.Replace('a', '4').Replace('e', '3').Replace('i', '1').Replace('o', '0').Replace('s', '5');    //      str = str.Replace("a", "4");
		}                                                                                                                //      str = str.Replace("e", "3");
                                                                                                                                 //      tr = str.Replace("i", "1");
		                                                                                                                 //      str = str.Replace("o", "0");
		                                                                                                                 //      str = str.Replace("s", "5");
		                                                                                                                 //
		                                                                                                                 //      return str;
		                                                                                                                 //     }
		
		
		
		public static string[] IsFourLetters(string[] arr) // Create a function that takes an array of strings and returns the words that are exactly four letters.
		{                                                      //Or  {
			List<string> X = new List<string>();           //
			foreach (string str in arr)                    //       return arr.Where(x => x.Length == 4).ToArray();
			{                                              //
				if (str.Length == 4)                   //     }
				{
					X.Add(str);
				}
			}
			return X.ToArray();
		}

		public static string MonthName(int num)  // Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
		{                                                                                            //Or {
			return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);                  //     String s = "";
		}                                                                                            //     String[] arr = new string[13];
													     //   
													     //     arr[1] = "January";
													     //     arr[2] = "February";
													     //     arr[3] = "March";
													     //     arr[4] = "April";
													     //     arr[5] = "May";
													     //     arr[6] = "June";
													     //     arr[7] = "July";
													     //     arr[8] = "August";
													     //     arr[9] = "September";
													     //     arr[10] = "October";
													     //     arr[11] = "November";
													     //     arr[12] = "December";
													     //
													     //     s = arr[num];
													     //     return s;
													     //   }
		

		public static string Reverse(string str) //Create a function that takes a string as its argument and returns the string in reversed order.
		{                                                   //  Or  {
			char[] rev = str.ToCharArray();             //
								    //        return string.Concat(str.Reverse());
			Array.Reverse(rev);                         //
			                                            //      }
			return new string(rev);                     //
		}                                                   //
 
		public static int CountTrue(bool[] arr) // Create a function which returns the number of true values there are in an array.
		{                                                // Or {
			int counter = 0;                         //
								 //       return arr.Count(val => val);
			for (int i = 0; i < arr.Length; i++)     //
			{                                        //     }
				if (arr[i] == true) counter++;   
			}                                    
			return counter;                     
		}

		
		public static string FormatPhoneNumber(int[] numbers) // Create a function that returns the integers inside an array in a phone number format.
		{                                                                                                                                                                     // Or {
			return ("(" + numbers[0] + numbers[1] + numbers[2] + ") " + numbers[3] + numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9]);  //      return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
		}                                                                                                                                                                     //     }

		public static int CountVowels(string str) // Create a function that return the number of vowels inside a string.
		{                                                                // Or  {
			return str.Split('a', 'e', 'i', 'o', 'u').Length - 1;    //      
										 //        return str.Count(c=>"aeiou".Contains(c));
		}                                                                //     
										 //     }

		public static bool DoubleLetters(string word) //Create a function that takes a word and returns true if the word has two consecutive identical letters.
		{                                                    // Or  {
			for (int i = 0; i < word.Length - 1; i++)    //       int i=0;
			{                                            //     
				if (word[i] == word[i + 1])          //       while(i<word.Length-1 && word[i]!=word[i+1])
				{                                    //          { 
					return true;                 //           	i++;
				}                                    //          }
			}                                            //       
					return false;                //	       return word.Length-1!=i;
		}                                                    //      }

		
		public static int PosCom(int n) // Create a function that returns how many possible outcomes can come from a certain number of switches (on / off).
		{                                      // Or {
			return (int)Math.Pow(2, n);    //       int num = 1;
		}                                      //      
						       //       for (int i = 0; i < n; i++)
						       //         {
						       //             num *= 2;
						       //         }
						       //         
						       //       return num;
						       //    }

		
		public static bool isIdentical(string str)  //Create a function that returns true if a string only contains the same repeated char
		{                                              // Or {
			if(str.Distinct().Count() == 1)        //
			 {                                     //      return str.All( c => c == str[0]);
				return true;                   //
                         }                                     //    }
			                                       //
		        else                                   //
                         {                                     //
				return false;
                         }
		}

		public static double Mean(int[] arr) //Create a function that takes an array of numbers and returns the mean value rounded to two decimal places.
		{                                             // Or {
			return Math.Round(arr.Average(), 2);  //
		}                                             //         var sum = 0;
							      //
							      //         foreach (int i in arr)
							      //          {
							      //            sum += i;
							      //          }
							      //
							      //         return Math.Round(sum / (double) arr.Length, 2);
							      //      }

		
		public static string ReplaceVowels(string str, string ch) // Create a function that replaces all the vowels in a string str with a specified character ch.
		{                                                             // Or {                            Or else {
			return Regex.Replace(str, "[aeiou]", ch);             //                                             var vowels = new string[]{"a","e","i","o","u"};
		}                                                             //      str = str.Replace("a",ch);              
									      //      str = str.Replace("e",ch);             foreach(var vowel in vowels)
									      //      str = str.Replace("i",ch);             {
									      //      str = str.Replace("o",ch);               str = str.Replace(vowel, ch);
									      //      str = str.Replace("u",ch);             }
									      //      return str;  
									      //                                             return str;
									      //    }                                     }

		public static string SubReddit(string link) // Create a function to extract the name of the subreddit from its URL.
		{                                                                          // Or {                                                                Or else {
			                                                                   //                                                                            
		  string[] key = { "https:", "//www" , ".reddit" ,".com", "/r/", "/" };    //     return link.Replace("https://www.reddit.com/r/", "").Trim('/');           return link.Substring(25).TrimEnd('/');
											   //                                                                             
		   foreach (string str in key)                                             //    }                                                                        }
                    {                                                                     
	              link = link.Replace(str, "");                                     
                    }                                                                     
			                                                                      
		   return link;                                                          
		}

		
		public static bool XO(string str) // Create a function that return true if str contains the same number of X and O case insensitive and return also true when there are no X and O at all in str.
		{                                                                        // Or {
			return str.Split('X', 'x').Length == str.Split('O', 'o').Length; //      return  str.ToLower().Count(c => c == 'x') == str.ToLower().Count(c => c == 'o');
		}                                                                        //    }
		

		public static int[] NoOdds(int[] arr)  // Create a function that return only the even numbers inside an array
		{                                                     // Or {
			                                              //
			return arr.Where(n => n % 2 == 0).ToArray();  //       return Array.FindAll( arr, x => x % 2 ==0 );
								      //
		}                                                     //    }
		

		public static bool isLastCharacterN(string word) // Create a function that takes a string (a random name). If the last character of the name is an "n", return true, otherwise return false.
		{                                                     // Or {
			for (int i = 0; i < word.Length; i++)         //      if(word.EndsWith("n"))
			{                                             //       {
				i = word.Length - 1;                  //         return true;
								      //       }
				if (word[i] == 'n')                   //      return false;
				{                                     //    }
					return true;
				}
			}
			return false;
		}

		public static string FormatDate(string date) // Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.
		{                                                  // Or {
			DateTime inputDate = DateTime.Parse(date); //      return Convert.ToDateTime(date).ToString("yyyyddMM");
			return inputDate.ToString("yyyydMM");      //    }
		}
		

		public static bool GreaterThanOne(string str) // Given a fraction as a string, return whether or not it is greater than 1 when evaluated.
		{                                                // Or {
		   double d1 = Double.Parse(str.Split('/')[0]);  //     double[] arr = Array.ConvertAll(str.Split('/'), double.Parse);
		   double d2 = Double.Parse(str.Split('/')[1]);  //
		   						 //     return arr[0] / arr[1] > 1;
		   if (d1 > d2)                                  //    }
		   {                                            
		   	return true;                             
		   }                                            
		   else
		   {
		   	return false;
		   }
		}

		
		public static string AlphabetPosition(string text) // Create a function that replace every letter with its position in the alphabet and doesn't return anything in the text that isn't a letter.
		{                                                                                                                                                              // Or {                                                                                      // Or {
		   string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };   //      return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1)); //      string alphabet="abcdefghijklmnopqrstuvwxyz";
		   Regex rgx = new Regex("[^a-zA-Z0-9]");                                                                                                                      //    }                                                                                      //       List<string> Nums= new List<string>();
		   Regex xgr = new Regex(@"[\d-]");                                                                                                                            //                                                                                           //
		   text = rgx.Replace(text, "");                                                                                                                               //                                                                                           //       foreach(char c in text)
		   text = xgr.Replace(text, "");                                                                                                                               //                                                                                           //       {
		   																		               //                                                                                           //          if(alphabet.Contains(c.ToString().ToLower()))
		   foreach (string str in alphabet)                                                                                                                            //                                                                                           //           { Nums.Add((alphabet.IndexOf(c.ToString().ToLower())+1).ToString());}
		   {                                                                                                                                                           //                                                                                           //       }
		   	text = text.ToLower().Replace(str, (Array.IndexOf(alphabet, str) + 1).ToString() + " ");                                                               //                                                                                           //       
		   																			       //                                                                                           //       string result= string.Join(" ", Nums.ToArray());
		   }                                                                                                                                                                                                                                                        //       return result;
		   																														            //    }																														   //     }
		   if (text.Length > 1)
		   {
		   	return text.Substring(0, text.Length - 1);
		   }
                          
		   return text;
		}
		

		public int LengthOfLastWord(string s)
		{
			if (s.Split(' ').Length > 0)
			{
			   return s.Length - s.Split(' ').Length;
                        }

			return 0;
		}

		public static string LongBurp(int b) // Create a function that returns the string "Burp" with the amount of "r" determined by the input parameters of the function.
		{	                                            // Or {
			return "Bu" + new string('r', b) + "p";     //       string input = "";
		}                                                   // 
								    //       for (int i=0;i < b; i++)
								    //        {
								    //         input += "r";
								    //        }
								    // 
								    //        return "Bu"+input+"p";
								    //    }

		
		public static string FindNeedle(object[] haystack) // Create a function that takes an array full of junk but containing one "needle", after finding the needle it should return the message "found the needle at position..."
		{                                                                                          // Or {
			if (haystack.Contains("needle"))                                                    //      int i=0;
			{                                                                                   //      while(haystack[i]!="needle")
				return "found the needle at position " + Array.IndexOf(haystack, "needle"); //       {
			}                                                                                   //          i++;
													    //       }
			return "No needle found in haystack";                                               //
																							//      return "found the needle at position " + i;
		}

		public static int Litres(double time) // Create a function that return 0.5 litre
		{
			return (int)(time / 2);
		}

		
		public static string BreakCamelCase(string str) //Create a function that will break up camel casing, using a space between words.
		{                                                           // Or {                                   Or else {
			return Regex.Replace(str, "(\\B[A-Z])", " $1");     //      var sb = new StringBuilder();                return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
									    //                                                }
		}							    //       foreach (var symbol in str)
									    //       {
									    //          if (char.IsUpper(symbol)) 
									    //           {
									    //             sb.Append(" ");
									    //           }
									    //           sb.Append(symbol);
									    //       }
									    //
									    //       return sb.ToString().Trim();
									    						//     }
		

		public static int[] minMax(int[] lst) // Create a function that returns both the minimum and maximum number of the given list/array.
		{
			return new int[] { lst.Min(), lst.Max() }; 		                             
		}

		
		public static string DoubleChar(string str) // Create a function that takes a string and returns a string in which each character is repeated once.
		{                                                                           // Or {                                                   Or else {                                           Or else {
		  return String.Concat(str.Select(c => c.ToString() + c.ToString()));       //      var word = "";                                             var sb = new StringBuilder();                       string.Concat(str.Select(s=>$"{s}{s}"));
											    //                                                                                                                   }
											    //      for(var i = 0; i < str.Length; i++)                        foreach (char c in str.ToCharArray())               
											    //       {                                                          {
											    //        word += str[i].ToString() + str[i].ToString();              sb.Append(c).Append(c);
											    //       }                                                          }
											    //          
											    //      return word;                                                return sb.ToString();
											    //    }                                                           }
		}

		
		public static void fizzBuzz(int n)  // Create a function that prints FizzBuzz on the console when n is a mutiple of 3 and 5, Fizz when n is a multiple of 3, and Buzz when n is multiple of 5.
		{

		   for (int i = 1; i <= n; i++)
		   {
		       if (i % 3 == 0 && i % 5 == 0)
		   	{
		   	   Console.WriteLine("FizzBuzz");
		   	}

		       else if (i % 3 == 0)
                        {
			   Console.WriteLine("Fizz");
                        }

		       else if (i % 5 == 0)
                        {
			   Console.WriteLine("Buzz");
                        }

                      else
                       {
			   Console.WriteLine(i);
                       }
		   }
			
		}

		public static String numberInWord(int num)
		{

			string str;

			for (int i = 0; i <= 5; i++)
			{
				if (i == num)
				{
					str = num.ToString();
				}
				else if (num > i && num <= 10)
				{
					str = "OTHER";
				}
			}

			return str;
		}

		
		public static String printEqual(int num1, int num2, int num3)
		{
			if (num1 == num2 && num1 == num3)
			{
				return "All numbers are equal";
			}

			else if (num1 != num2 && num1 != num3 && num2 != num3)
			{
				return "All numbers are different";
			}

			else if (num1 < 0 || num2 < 0 || num3 < 0)
			{
				return "Invalid value";
			}

			else
			{
				return "Neither all are equal or different";
			}
		}
		
		public static string RemoveUrlAnchor(string url) // Create a function that returns the url with anything after the anchor (#) removed.
		{                                                                             // Or  {
			if (url.Contains("#"))                                                //      return url.Split('#')[0];
			{                                                                     //     }
				return url.Substring(0, url.IndexOf('#') + 1).TrimEnd('#');   //
			}                                                                     //

			return url;
		}
		

		// Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.
		private static readonly Dictionary<char, int> literals = new Dictionary<char, int>                    // Or    public static int Solution(string roman)
									          {                                   //         {
									            {'I', 1},                         //          return roman.Replace("CM", "DCCCC")
									            {'V', 5},                         //                      .Replace("CD", "CCCC")
									            {'X', 10},                        //                      .Replace("XC", "LXXXX")
									            {'L', 50},                        //                      .Replace("XL", "XXXX")
									            {'C', 100},                       //                      .Replace("IX", "VIIII")
									            {'D', 500},                       //                      .Replace("IV", "IIII")
									            {'M', 1000},                      //                      .Sum(c => Translate(c));
									          };                                  //          }
			                                                                                              //
		     public static int Solution(string roman)                                                         //       public static int Translate(char c)
		      {                                                                                               //         {
			int result = 0;                                                                               //           switch (c)
			int max = 0;                                                                                  //            {
						                                                                      //               case 'I': return 1;
			foreach (var c in roman.Reverse())                                                            //               case 'V': return 5;
			{                                                                                             //               case 'X': return 10;
				int value = literals[c];                                                              //               case 'L': return 50;
						       						                      //               case 'C': return 100;
				if (value < max)                                                                      //               case 'D': return 500;
				{                                                                                     //               case 'M': return 1000;
					result -= value;                                                              //               default: return 0;
				}                                                                                     //             }
					else                                                                          //         }
					{                                                                             //
						result += value;                                                      //
						max = value;
					}
				}
				return result;
			}
	             }
	
	       public static bool Narcissistic(int value) // Create a function that  return true or false depending upon whether the given number is a Narcissistic number in base 10. Narcissistic Number is a positive number which is the sum of its own digits, each raised to the power of the number of digits in a given base.
                {                                                                                         // Or {                                                                                        // Or {
                    var str = value.ToString();                                                           //      double sum = 0;                                                                        //      int x = value.ToString().Length;
                    return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;    //                                                                                             //      int total = 0;
                }                                                                                         //       foreach (char item in value.ToString())                                               //      int init = value;
                                                                                                          //         {                                                                                   //      
                                                                                                          //           sum += Math.Pow(int.Parse(item.ToString()), (int)value.ToString().Length);        //      while (value >= 1) 
                                                                                                          //         }                                                                                   //       {
                                                                                                          //                                                                                             //          var n = value % 10;
                                                                                                          //       return sum == value;                                                                  //          total += (int)Math.Pow(n, x);  
                                                                                                          //    }                                                                                        //           value /= 10;
                                                                                                                                                                                                         //       }
                                                                                                                                                                                                         //      
                                                                                                                                                                                                         //     return init == total;
                                                                                                                                                                                                         //   }
	
	     public static string alternateCase(string s) // Create a function which switch every letter in string s from upper to lower and from lower to upper.
             {                                                  // Or {                                                                                               // Or {
                 char[] array = s.ToCharArray();                //       return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));    //      string str = null;
                                                                //    }                                                                                               //      
                 for (int i = 0; i < array.Length; i++)         //                                                                                                    //      foreach (char c in s)
                 {                                              //                                                                                                    //       {
                     char c = array[i];                         //                                                                                                    //         if (Char.IsUpper(c))
                                                                //                                                                                                    //          {
                     if (char.IsUpper(c))                       //                                                                                                    //           str += Char.ToLower(c);
                     {                                          //                                                                                                    //          }
                         array[i] = char.ToLower(c);                                                                                                                  //    
                     }                                                                                                                                                //         else
                                                                                                                                                                      //          {
                     else                                                                                                                                             //           str +=  Char.ToUpper(c);
                     {                                                                                                                                                //          }
                         array[i] = char.ToUpper(c);                                                                                                                  //       }
                     }                                                                                                                                                //       
                 }                                                                                                                                                    //       return str;
                                                                                                                                                                      //     }
                 return new string(array);
             }
	
	
	
	   public static Dictionary<char, int> Count(string str) // Create a function that counts all the occurring characters in a string.  If the string is empty, the result should be empty.
            {                                                          // Or {                                                                   // Or {
                var result = new Dictionary<char, int>();              //       Dictionary<char, int> dic = new  Dictionary<char, int>();        //      
                                                                       //                                                                        //      return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
                foreach (char c in str)                                //       foreach(char c in str)                                           //
                {                                                      //         {                                                              //    }
                    int count;                                         //           if(dic.ContainsKey(c))
                    result.TryGetValue(c, out count);                  //            {
                    result[c] = count + 1;                             //              dic[c] += 1;
                }                                                      //            }
                                                                       //
                return result;                                         //           else
            }                                                           //            {
                                                                        //               dic.Add(c,1);
                                                                        //            }
                                                                        //         }
                                                                        //
                                                                        //       return dic;
                                                                        //    }

	    public static int TrailingZeros(int n) //Create a function that will calculate the number of trailing zeros in a factorial of a given number.
            {
                // 1-4   ==> 0 trailing 0s
                // 5-9   ==> 1 trailing 0s
                // 10-14 ==> 2 trailing 0s
                // 15-19 ==> 3 trailing 0s
                // 20-24 ==> 4 trailing 0s
                // 25-29 ==> 6 trailing 0s
                //   every multiple of 5 adds another 0 (5, 25, 125, 625, etc.)
    
                                                      // Or {                                        //  Or {                        // Or {
                int result = 0;                       //      int result = 0;                        //       int result = 0;        //       return Enumerable.Range(1, (int)Math.Log(n,5)).Sum(x => n / (int)Math.Pow(5,x));
                int start = 1;                        //                                             //                              //    }
                                                      //      for (int i = 5; i <= n; i *= 5)        //       while(num > 0)         //
                while (n >= start)                    //        {                                    //        {
                {                                     //           result += n/i;                    //           num /= 5;
                    start *= 5;                       //        }                                    //           zeros += num;
                    result += (int)n / start;         //                                             //        }
                }                                     //      return result;                         //      return result;
                return result;                        //    }                                        //     }
            }
	
	   public static int[] SortArray(int[] array) // Create a function that  sort the odd numbers in ascending order while leaving the even numbers at their original positions.
           {                                                    // Or {
               List<int> odd = new List<int>();                 //       Queue<int> odds = new Queue<int>(array.Where(e => e%2 == 1).OrderBy(e => e));
                                                                // 
               foreach (var number in array)                    //        return array.Select(e => e%2 == 1 ? odds.Dequeue() : e).ToArray();
               {                                                //    }
                   if (number % 2 != 0)                         //
                       odd.Add(number);
               }
               int[] oddAr = odd.ToArray();
               Array.Sort(oddAr);
      
      
               for (int i = 0, j = 0; i < array.Length; i++)
               {
                   if (array[i] % 2 != 0)
                   {
                       array[i] = oddAr[j];
                       j++;
                   }
               }
               return array;
           }
	
	public static char FindMissingLetter(char[] array) //Create a method that takes an array of consecutive letters as input and that returns the missing letter in the array.
        {                                                    //Or  {                                         //  Or {                                                                                                                                     // Or {
                                                             //      int index = 0;                          //        public static char FindMissingLetter(char[] array) => (char)Enumerable.Range(array[0], 25).First(x => !array.Contains((char)x));   //      char c = arr.First();
            for (int i = 0; i < array.Length - 1; i++)       //                                              //     }                                                                                                                                     //      char n = arr.Last();
            {                                                //      while(array[ind+1]-array[ind]==1)       //                                                                                                                                           //      return (char)(n*(n+1)/2 - (c-1)*c/2 - arr.Sum(c => c));
                if (array[i + 1] - array[i] > 1)             //       {                                                                                                                                                                                   //    }                                                
                {                                            //         index++;
                    return (char)(array[i] + 1);             //       }
                }                                            //    
            }                                                //       return (char)(array[index]+1);       
                                                             //     }
            return ' ';                                      //
        }
	
	public static string Tickets(int[] people) //Create a function that determines if a till got enough money to serve all customers in line for an item that costs 25, starting with 0. The customers have either 25, 75 or 100 on them.
        {                                                   // Or  {
            int twentyFives = 0, fifties = 0;               //       int m25=0; 
                                                            //       int m50=0;
            foreach (var bill in people)              //
            {                                               //       for (int i=0;i<p.Length&m25>=0;i++)
                switch (bill)                               //        {
                {                                           //          m25+=(people[i]==25 ? 25 : people[i]==50 ? -25 : m50<50 ? -75 : -25);
                    case 25:                                //          m50+=(people[i]==25 ? 0  : people[i]==50 ?  50 : m50<50 ?   0 : -50);
                        ++twentyFives;                      //        }
                        break;                              //
                    case 50:                                //        return m25<0 ? "NO" : "YES";
                        --twentyFives;                      //     }
                        ++fifties;
                        break;
                    case 100:
                        if (fifties == 0)
                        {
                            twentyFives -= 3;
                        }
                        else
                        {
                            --twentyFives;
                            --fifties;
                        }
                        break;
                }

                if (twentyFives < 0 || fifties < 0)
                {
                    return "NO";
                }
            }

            return "YES";
        }
	
	public static long[] SumDigPow(long a, long b) //Create a function that defines the range [a, b] (inclusive) and outputs a list of the sorted numbers that the Sum of the Digits Raised To The Consecutive Powers equal the number itself.
        {                                                                                                                   //Or {
            List<long> values = new List<long>();                                                                           //
                                                                                                                            //     return Enumerable.Range((int)a, (int)(b - a)).Where(x => x < 10 || x.ToString().ToCharArray().Select((y,i) => Math.Pow(int.Parse(y.ToString()),i+1)).Sum()==x).Select(x=>(long)x).ToArray();       
            for (long j = a; j <= b; j++)                                                                                   //        
            {                                                                                                               //   }                 
                if (j.ToString().Select((c, i) => Math.Pow(Char.GetNumericValue(c), i + 1)).Sum() == j)values.Add(j);       //
            }                                                                                                               //                             
                                                                                                                            //     
            return values.ToArray();                                                                                        //
        }
	
	public List<string> wave(string str) //Create a function that turns a string into a Mexican Wave. Return a list that contains that string in multiple iteration equal to its length where an uppercase is found on the next item at the next position. ex: wave("hello") ==> {"Hello", "hEllo", "heLlo", "helLo", "hellO"}
        {                                                   //  Or {                                                         // Or {
            List<string> waveList = new List<string>();     //      List<string> waveList = new List<string>();              //      List<string> waveList = new List<string>();
            for (int i = 0; i < str.Length; i++)            //      string[] a = str.Select(c => c.ToString()).ToArray();    //      for (int i = 0; i < str.Length; i++)
            {                                               //      for (int i =0; i< a.Length; i++)                         //       {
                char[] c = str.ToCharArray();               //       {                                                       //         if (str[i] == ' ')
                if (c[i] != ' ')                            //        if(a[i] != " ")                                        //          {
                {                                           //         {                                                     //            continue;
                    c[i] = Char.ToUpper(c[i]);              //           a[i] = a[i].ToUpper();                              //          }
                    waveList.Add(new string(c));            //           waveList.Add(string.Join("",a));                    //         waveList.Add(str.Substring(0, i) + char.ToUpper(str[i]) + str.Substring(i + 1, str.Length - (i + 1)));
                }                                           //           a[i] = a[i].ToLower();                              //       }
            }                                               //         }                                                     //      return waveList;
            return waveList;                                //      return waveList;                                         //    }   
        }                                                   //     }
	
	public static string[] Solution(string str) // Create a function that splits a string into an array of pairs of two characters. If the string contains an odd number of characters then it replaces the missing second character of the final pair with an underscore ('_').
        {                                                    // Or {                                                                                                 // Or {
            if (str.Length % 2 == 1)                         //       if (str.Length % 2 != 0)                                                                       //     return Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();
            {                                                //        {                                                                                             //    }
                str += "_";                                  //          str += '_';                                                                                 //
            }                                                //        }                                                                                             //   
                                                             //  
            List<string> list = new List<string>();          //       return Enumerable.Range(0, str.Length / 2).Select(i => str.Substring(2 * i, 2)).ToArray();
            for (int i = 0; i < str.Length; i += 2)          //    }
            {                                                //
                list.Add(str[i].ToString() + str[i + 1]);    //
            }                                                //
                                                             //
            return list.ToArray();                           //
        }                                                    //
    }
}
                                                                                                                                             

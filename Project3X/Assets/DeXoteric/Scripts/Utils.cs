using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DeXoteric
{
    public class Utils
    {
        #region Check if clicked over UI element

        public static bool IsPointerOverUIObject()
        {
            PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
            eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
            return results.Count > 0;
        }

        #endregion Check if clicked over UI element

        #region Check if app is running on mobile

        public static bool IsOnMobile()
        {
            bool value;

#if UNITY_ANDROID || UNITY_IOS
            value = true;
#endif
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBGL
            value = false;
#endif

            return value;
        }

        #endregion Check if app is running on mobile

        #region Convert number to roman numeral

        public static string ConvertToRomanNumerals(int number)
        {
            string romanNumeral = "";

            while (number > 0)
            {
                if (number >= 1000)
                {
                    romanNumeral = romanNumeral + "M";
                    number = number - 1000;
                }
                else if (number >= 900)
                {
                    romanNumeral = romanNumeral + "CM";
                    number = number - 900;
                }
                else if (number >= 500)
                {
                    romanNumeral = romanNumeral + "D";
                    number = number - 500;
                }
                else if (number >= 400)
                {
                    romanNumeral = romanNumeral + "CD";
                    number = number - 400;
                }
                else if (number >= 100)
                {
                    romanNumeral = romanNumeral + "C";
                    number = number - 100;
                }
                else if (number >= 90)
                {
                    romanNumeral = romanNumeral + "XC";
                    number = number - 90;
                }
                else if (number >= 50)
                {
                    romanNumeral = romanNumeral + "L";
                    number = number - 50;
                }
                else if (number >= 40)
                {
                    romanNumeral = romanNumeral + "XL";
                    number = number - 40;
                }
                else if (number > 10)
                {
                    romanNumeral = romanNumeral + "X";
                    number = number - 10;
                }
                else if (number <= 10)
                {
                    romanNumeral = romanNumeral + NumeralsOneToTen(number);
                    number = 0;
                }
            }

            return romanNumeral;
        }

        public static string NumeralsOneToTen(int number)
        {
            string roman;

            switch (number)
            {
                case 1:
                    roman = "I";
                    break;

                case 2:
                    roman = "II";
                    break;

                case 3:
                    roman = "III";
                    break;

                case 4:
                    roman = "IV";
                    break;

                case 5:
                    roman = "V";
                    break;

                case 6:
                    roman = "VI";
                    break;

                case 7:
                    roman = "VII";
                    break;

                case 8:
                    roman = "VIII";
                    break;

                case 9:
                    roman = "IX";
                    break;

                case 10:
                    roman = "X";
                    break;

                default:
                    roman = number.ToString();
                    break;
            }

            return roman;
        }

        #endregion Convert number to roman numeral

        #region Return random index number
        public static int RandomIndex()
        {
            return Random.Range(1000000, 9999999);
        }
        #endregion
    }
}
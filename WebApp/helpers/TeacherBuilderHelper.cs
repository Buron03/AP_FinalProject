using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;
using static AppContext.Const.Constant;

namespace WebApp.Helpers
{
    public class TeacherBuilderHelper
    {

        public TeacherBuilderHelper(School db)
        {
            this.db = db;
        }

        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public State State { get; set; }
        private School db;


        public string CreateCURP()
        {
            string CURP = String.Empty;
            CURP += FirstSurname[0];
            CURP += FirstSurname[1];
            CURP += SecondSurname[0];
            if (SecondName != "" && (FirstName.ToUpper() == "JOSÉ" || FirstName.ToUpper() == "MARÍA" 
            || FirstName.ToUpper() == "JOSE" || FirstName.ToUpper() == "MARIA"))
            {
                CURP += SecondName[0];
            }
            else
            {
                CURP += FirstName[0];
            }
            CURP += (DateOfBirth.Year%100).ToString().PadLeft(2, '0');
            CURP += DateOfBirth.Month.ToString().PadLeft(2, '0');
            CURP += DateOfBirth.Day.ToString().PadLeft(2, '0');
            CURP += GetGenderChar();
            CURP += GetStateCode();
            CURP += GetFirstInternalConsonantFirstSurname();
            CURP += GetFirstInternalConsonantSecondSurname();
            CURP += GetFirstInternalConsonantFirstName();
            CURP += GetBirthNumber();
            CURP += GetControlDigit(CURP);

            CURP = CURP.ToUpper();
            return CURP;         
        }

        
        public char GetGenderChar()
        {
            switch (Gender)
            {
                case "Female":
                    return 'M';
                case "Male":
                    return 'H';
                default:
                    return 'X';
            }
        }

         public string GetStateCode()
        {
            switch(State)
            {
                case State.Aguascalientes:
                    return "AS";
                case State.BajaCalifornia:
                    return "BC";
                case State.BajaCaliforniaSur:
                    return "BS";
                case State.Campeche:
                    return "CC";
                case State.Chiapas:
                    return "CS";
                case State.Chihuahua:
                    return "CH";
                case State.CiudadDeMexico:
                    return "DF";
                case State.Coahuila:
                    return "CL";
                case State.Colima:
                    return "CM";
                case State.Durango:
                    return "DG";
                case State.Guanajuato:
                    return "GT";
                case State.Guerrero:
                    return "GR";
                case State.Hidalgo:
                    return "HG";
                case State.Jalisco:
                    return "JC";
                case State.Mexico:
                    return "MC";
                case State.Michoacan:
                    return "MN";
                case State.Morelos:
                    return "MS";
                case State.Nayarit:
                    return "NT";
                case State.NuevoLeon:
                    return "NL";
                case State.Oaxaca:
                    return "OC";
                case State.Puebla:
                    return "PL";
                case State.Queretaro:
                    return "QO";
                case State.QuintanaRoo:
                    return "QR";
                case State.SanLuisPotosi:
                    return "SP";
                case State.Sinaloa:
                    return "SL";
                case State.Sonora:
                    return "SR";
                case State.Tabasco:
                    return "TC";
                case State.Tamaulipas:
                    return "TS";
                case State.Tlaxcala:
                    return "TL";
                case State.Veracruz:
                    return "VZ";
                case State.Yucatan:
                    return "YN";
                case State.Zacatecas:
                    return "ZS";                                                                                                    
                default:
                    return "XX";    
            }
        }

         public char GetFirstInternalConsonantFirstSurname()
        {
            foreach (char c in FirstSurname)
            {
                if (c.Equals(FirstSurname[0]))
                {
                    continue;
                }
                
                if (IsAVowel(c))
                {
                    continue;
                }

                return c;
            }
            return 'X';
        }

        public char GetFirstInternalConsonantSecondSurname()
        {
            foreach (char c in SecondSurname)
            {
                if (c.Equals(SecondSurname[0]))
                {
                    continue;
                }
                
                if (IsAVowel(c))
                {
                    continue;
                }

                return c;
            }
            return 'X';
        }

        public char GetFirstInternalConsonantFirstName()
        {
            string name = String.Empty;

            if (SecondName != "" && (FirstName) == "JOSÉ" || FirstName.ToUpper() == "MARÍA" 
            || FirstName.ToUpper() == "JOSE" || FirstName.ToUpper() == "MARIA")
            {
                name += SecondName;
            }
            else
            {
                name += FirstName;
            }

            foreach (char c in name)
            {
                if (c.Equals(name[0]))
                {
                    continue;
                }
                
                if (IsAVowel(c))
                {
                    continue;
                }

                return c;
            }
            return 'X';            
        }

        public char GetBirthNumber()
        {
            if (DateOfBirth.Year < 2000)
            {
                return (char) (new Random()).Next('0', '9');
            }
            else
            {
                return (char) (new Random()).Next('A', 'Z');
            }
        }

        public char GetControlDigit(string CURP)
        {
            char c = ' '; 
            do
            {
                c = (char) (new Random()).Next('0', '9');
            } while (!IsAvailableCURP(CURP + c));

            return c;
        }

        public bool IsAvailableCURP(string CURP)
        {
            foreach (var teacher in db.Teachers)
            {
                if (teacher.Curp == CURP)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsAVowel(char c)
        {
            string aux = c + String.Empty;
            aux = aux.ToUpper(); 
            if (aux == "A" || aux == "E" || aux == "I" || aux == "O" || aux == "U")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

      public int CreatePaycheckNumber()
        {
            int payrollNumber = 0;
            do
            {
                payrollNumber = (new Random()).Next(1, 999);
            } while (!IsAvailablePaycheckNumber(payrollNumber));

            return payrollNumber;
        }

        public bool IsAvailablePaycheckNumber(int payrollNumber)
        {
            foreach (var teacher in db.Teachers)
            {
                if (teacher.PayrollNumber == payrollNumber)
                {
                    return false;
                }
            }
            return true;
        }

        public string CreatePassword()
        {
            return "BuronSuave03";
        }

        public string CreateRFC()
        {
            string RFC = String.Empty;
            RFC += FirstSurname[0];
            RFC += FirstSurname[1];
            RFC += SecondSurname[0];
            if (SecondName != "" && (FirstName.ToUpper() == "JOSÉ" || FirstName.ToUpper() == "MARÍA" 
            || FirstName.ToUpper() == "JOSE" || FirstName.ToUpper() == "MARIA"))
            {
                RFC += SecondName[0];
            }
            else
            {
                RFC += FirstName[0];
            }
            RFC += (DateOfBirth.Year%100).ToString().PadLeft(2, '0');
            RFC += DateOfBirth.Month.ToString().PadLeft(2, '0');
            RFC += DateOfBirth.Day.ToString().PadLeft(2, '0');
            GenerateHomokey(ref RFC);
            RFC = RFC.ToUpper();
            return RFC;
        }

        public void GenerateHomokey(ref string RFC)
        {
            string key = String.Empty;
            do 
            {
                key = String.Empty;
                key += (char) (new Random()).Next('A', 'Z');
                key += (char) (new Random()).Next('A', 'Z');
                key += (new Random()).Next(0, 9);
            } while (!IsAvailableRFC(RFC + key));

            RFC += key;
        }

        public bool IsAvailableRFC(string RFC)
        {
            foreach (var teacher in db.Teachers)
            {
                if (teacher.Rfc == RFC)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
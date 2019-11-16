using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DesignPatterns.GoF.Creational.Builder
{
    // In practice, you'd create a font file that would store this information. See for example FIGfonts.
    public class CharacterMapping
    {
        private Dictionary<char, string> _characterMappings = new Dictionary<char, string>
        {
            {
                'a',
@"

        
        
   __ _ 
  / _` |
 | (_| |
  \__,_|
        
        
"
            },
            {
                'b',
@"

  _     
 | |    
 | |__  
 | '_ \ 
 | |_) |
 |_.__/ 
        
        
"
            },
            {
                'c',
@"

       
       
   ___ 
  / __|
 | (__ 
  \___|
       
       
"
            },
            {
                'd',
@"

      _ 
     | |
   __| |
  / _` |
 | (_| |
  \__,_|
        
        
"
            },
            {
                'e',
@"

       
       
   ___ 
  / _ \
 |  __/
  \___|
       
       
"
            },
            {
                'f',
@"

   __ 
  / _|
 | |_ 
 |  _|
 | |  
 |_|  
      
      
"
            },
            {
                'g',
@"

        
        
   __ _ 
  / _` |
 | (_| |
  \__, |
   __/ |
  |___/ 
"
            },
            {
                'h',
@"

  _     
 | |    
 | |__  
 | '_ \ 
 | | | |
 |_| |_|
        
        
"
            },
            {
                'i',
@"

  _ 
 (_)
  _ 
 | |
 | |
 |_|
    
    
"
            },
            {
                'j',
@"

    _ 
   (_)
    _ 
   | |
   | |
   | |
  _/ |
 |__/ 
"
            },
            {
                'k',
@"

  _    
 | |   
 | | __
 | |/ /
 |   < 
 |_|\_\
       
       
"
            },
            {
                'l',
@"

  _ 
 | |
 | |
 | |
 | |
 |_|
    
    
"
            },
            {
                'm',
@"

            
            
  _ __ ___  
 | '_ ` _ \ 
 | | | | | |
 |_| |_| |_|
            
            
"
            },
            {
                'n',
@"

        
        
  _ __  
 | '_ \ 
 | | | |
 |_| |_|
        
        
"
            },
            {
                'o',
@"

        
        
   ___  
  / _ \ 
 | (_) |
  \___/ 
        
        
"
            },
            {
                'p',
@"

        
        
  _ __  
 | '_ \ 
 | |_) |
 | .__/ 
 | |    
 |_|    
"
            },
            {
                'q',
@"

        
        
   __ _ 
  / _` |
 | (_| |
  \__, |
     | |
     |_|
"
            },
            {
                'r',
@"

       
       
  _ __ 
 | '__|
 | |   
 |_|   
       
       
"
            },
            {
                's',
@"

      
      
  ___ 
 / __|
 \__ \
 |___/
      
      
"
            },
            {
                't',
@"

  _   
 | |  
 | |_ 
 | __|
 | |_ 
  \__|
      
      
"
            },
            {
                'u',
@"

        
        
  _   _ 
 | | | |
 | |_| |
  \__,_|
        
        
"
            },
            {
                'v',
@"

        
        
 __   __
 \ \ / /
  \ V / 
   \_/  
        
        
"
            },
            {
                'w',
@"

           
           
 __      __
 \ \ /\ / /
  \ V  V / 
   \_/\_/  
           
           
"
            },
            {
                'x',
@"

       
       
 __  __
 \ \/ /
  >  < 
 /_/\_\
       
       
"
            },
            {
                'y',
@"

        
        
  _   _ 
 | | | |
 | |_| |
  \__, |
   __/ |
  |___/ 
"
            },
            {
                'z',
@"

      
      
  ____
 |_  /
  / / 
 /___|
      
      
"
            },
        };

        public string GetCharacter(char c) => RemoveEOL(_characterMappings?[c]);

        private string RemoveEOL(string asciiCharacter)
        {
            // remove any new lines, and if line length was less than 8, add spaces
            // there should have been only 9 lines in total
            return asciiCharacter;
        }
    }
}

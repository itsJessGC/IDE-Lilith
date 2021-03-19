
using System;
using System.IO;



namespace Cs
{
    class Program
    {
       public struct token 
        {
            public token_types type;
            public string lexema ;
        }
        public const int MAXLENID = 32;
        public const int MAXLENBUF = 1024;
        public const int MAXRESWORDS = 4;

       public enum token_types {
            TKN_BEGIN, TKN_END, TKN_READ, TKN_WRITE, TKN_ID,
            TKN_NUM, TKN_LPAREN, TKN_RPAREN, TKN_SEMICOLON, TKN_COMMA,
            TKN_ASSIGN, TKN_ADD, TKN_MINUS, TKN_EOF, TKN_ERROR
        }


        enum States {
            IN_START, IN_ID, IN_NUM, IN_LPAREN, IN_RPAREN, IN_SEMICOLON,
            IN_COMMA, IN_ASSIGN, IN_ADD, IN_MINUS, IN_EOF, IN_ERROR, IN_DONE
        }


         
     //esta funcion lo que va ser es que elimine los comentarios y dejar todo en un string
     //falta que elimine los comentarios 
      static String makeString(StreamReader fp)
        {
            String line=null;
            String recipiente = null;
            try
            {
                //Read the first line of text
                line = fp.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //junta el texto en un string 
                    recipiente += line;
                    //Read the next line
                    line = fp.ReadLine();
                }
                //close the file
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Terminó");
            }

            return recipiente;
        }

        
        //esta funcion checa las palabras que le son enviadas para identificar 
        //si estas son palabras reservadas 
        //aqui la meta es que cheque los identificadores , los numeros , digitos y caracteres 

        static void queTokenes(String palabra) {
            if (palabra.Equals("program")|| 
                palabra.Equals("if")||
                palabra.Equals("else")||
                palabra.Equals("fi")||
                palabra.Equals("do")||
                palabra.Equals("until")||
                palabra.Equals("while")||
                palabra.Equals("read")||
                palabra.Equals("case") ||
                palabra.Equals("write") ||
                palabra.Equals("float")||
                palabra.Equals("int") ||
                palabra.Equals("bool")||
                palabra.Equals("not") ||
                palabra.Equals("and")||
                palabra.Equals("or")
                )
            {
                Console.WriteLine(palabra+"   = Reservada");
            }
        
        }


        //esta funcion checa y va haciendo palabras asta que encuentre un digito especial 
        //en caso de que asi sea checa la palabra y la manda a la funcion de arriba 
        //y ademas que identifica los signos especiales 
       static void encontrarTokens(String linea,int largo) {
        token tok;
            
            tok.lexema = null;
            int pos = 0;
            char caracter;
            int index = 0;
            while (index<largo )
            {
                caracter = linea[index];
                switch (caracter)
                {
                    case ' ':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        index++;
                        break;
                    case '(':
                        
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("(   = simbolo");
                        index++;
                        break;
                    case ')':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine(")   = simbolo");
                        index++;
                        break;
                    case ';':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine(";   = simbolo");
                        index++;
                        break;
                    case ',':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine(",   = simbolo");
                        index++;
                        break;
                    case ':':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine(":   = simbolo");
                        index++;
                        break;
                    case '+':
                        queTokenes(tok.lexema);
                        if(linea[index+1].Equals('=')) {
                            Console.WriteLine("+=   = simbolo");
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("+   = simbolo");
                        }
                        tok.lexema = "";
                        index++;
                        break;
                    case '-':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                            Console.WriteLine("-=   = simbolo");
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("-   = simbolo");
                        }
                        index++;
                        break;
                    case '*':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("*   = simbolo");
                        index++;
                        break;
                    case '/':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("/   = simbolo");
                        index++;
                        break;
                    case '^':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("^   = simbolo");
                        index++;
                        break;
                    case '<':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                            Console.WriteLine("<=   = simbolo");
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("<   = simbolo");
                        }
                        index++;
                        break;
                    case '>':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                           Console.WriteLine(">=   = simbolo");
                            index++;
                        }
                        else
                        {
                            Console.WriteLine(">   = simbolo");
                        }
                        index++;
                        break;
                    case '=':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                           Console.WriteLine("==   = simbolo");
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("=   = simbolo");
                        }
                        index++;
                        break;
                    case '!':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        if (linea[index + 1].Equals('='))
                        {
                            Console.WriteLine("!=   = simbolo");
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("!   = simbolo");
                        }
                        index++;
                        break;
                    case '{':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("{    = simbolo");
                        index++;
                        break;
                    case '}':
                        queTokenes(tok.lexema);
                        tok.lexema = "";
                        Console.WriteLine("}    = simbolo");
                        index++;
                        break;
                    default:
                        tok.lexema  += caracter;
                        index++;
                        break;
                }
            }
        
        }
     
 
                  
                 
                     
         
         
        static void Main(string[] args)// aqui se reciven los atributos que seria solo el del archivo que va a buscar 
        {
            String linea;
          
            try
            {
                StreamReader fp = new StreamReader("C:\\Users\\OMAREFRENSANCHEZ\\OneDrive - Universidad Autónoma de Aguascalientes\\OCTAVO SEMESTRE\\COMPILADORES I\\FINAL\\prueba.txt");// aqui va el args[] y no se cual lleve el nombre del archivo 
                 // esta funcion se encarga de hacer todo el texto en
                //un string para manipularlo mucho mas facil 
                linea= makeString(fp);
                //Console.WriteLine(linea); esto es para ver como imprime el string

                //esto se encarga de encontrar los tokens en el string
                encontrarTokens(linea,linea.Length);
                       

                  
                //close the file
                fp.Close();
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}

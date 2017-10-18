using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zuoye{       
    class Program  
    {               
        static void Main(string[] args)      
        {        
            double No = double.Parse (Console.ReadLine());   
            double Nt = double.Parse(Console.ReadLine());   
            Calculator c = new Calculator();   
            aa:            
            Console.WriteLine("请输入要进行的操作：1.加法 2.减法 3.乘法 4.除法 0.退出");    
            int  enter = int.Parse (Console.ReadLine());        
            switch (enter)            {    
                case 1: c.addition(No, Nt); goto aa; //加       
                case 2: c.subtraction(No, Nt); goto aa; //减        
                case 3: c.multiplication(No, Nt); goto aa; //乘       
                case 4: c.division(No, Nt); goto aa; //除         
                case 0: Environment.Exit(0); break; //退出      
            }           
            Console.WriteLine("是否继续进行操作");   
        }   
    }    class Calculator    {  
        /**        
         * * 引入两个变量Number one，Number two；         
         * * 用这两个变量进行加减乘除运算      
         * * **/       
        public void addition(double No,double Nt)//加法      
        {          
            try{    
                Console.WriteLine(No+Nt);     
            }            catch(Exception ex)        
            {                       
                Console .WriteLine ("加法错误");       
                throw ex;        
            }    
        }     
        public void subtraction(double No, double Nt)//减法  
        {        
            /**     
             * * No是被减数;      
             * * Nt是减数          
             * * **/           
            try         
            {            
                Console.WriteLine(No - Nt);   
            }            catch (Exception ex)     
            {               
                Console.WriteLine("减法错误");   
                throw ex;         
            }        
        }       
        public void multiplication(double No, double Nt)//乘法  
        {          
            try        
            {            
                Console.WriteLine(No * Nt);    
            }            
            catch (Exception ex)  
            {              
                Console.WriteLine("乘法错误");  
                throw ex;        
            }      
        }     
        public void division(double No, double Nt)//除法    
        {          
            /**      
             * * No是被除数;    
             * * Nt是除数          
             * * **/         
            if (Nt == 0)          
            {                
                Console.WriteLine("除数为0");  
            }           
            try        
            {           
                Console.WriteLine(No / Nt);      
            }           
            catch (Exception ex)       
            {              
                Console.WriteLine("除法错误");      
                throw ex;          
            }     
        }  
    }
}


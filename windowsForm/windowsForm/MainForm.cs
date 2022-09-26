/*
 * Created by SharpDevelop.
 * User: Leandro
 * Date: 25/9/2022
 * Time: 19:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace windowsForm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
       		
//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
				
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
				
		
		void BotonClick(object sender, EventArgs e)
		{
			
		
			int monto = int.Parse(textBoxA.Text);
			int cambio = int.Parse(textBoxB.Text);
		    int r = monto / cambio;	   
		    int i = 0, c = 0, d = 0, E = 0, f = 0, g = 0, h = 0, j = 0, k = 0, l = 0, m = 0, Total = 0;
		    
		    TotalC.Text = r.ToString();
		   
		       Total = r;
		    if(monedas.Text == "Dolar."){
		    	
         
            while (Total >= 100)
            {
               
			 Total = Total - 100;
                i++;
            }
          
            
            while (Total >= 50)
            {
                Total = Total - 50;
                c++;
            }
         
            while (Total >= 20)
            {
                Total = Total - 20;
                d++;
            }
        

            while (Total >= 10)
            {
                Total = Total - 10;
                E++;
            }
      
            while (Total >= 5)
            {
                Total = Total - 5;
                f++;
            }
       
            while (Total >= 2)
            {
                Total = Total - 2;
                g++;
            }
       

            while (Total >= 1)
            {
                Total = Total - 1;
                h++;
            }
       
           
            MessageBox.Show("Cantidad de billetes de 100 Dolares :  " + i + "\n\n" + 
                                "Cantidad de billetes de 50 Dolares :  " + c + "\n\n" + 
                                "Cantidad de billetes de 20 Dolares :  " + d + "\n\n" + 
                                "Cantidad de billetes de 10 Dolares :  " + E + "\n\n" + 
                                "Cantidad de billetes de 5 Dolares :  " + f + "\n\n" + 
                                "Cantidad de billetes de 2 Dolares :  " + g + "\n\n"+ 
                                "Cantidad de billetes de 1 Dolares :  " + h);
            }
                
		    
                               
               if(monedas.Text == "Euro."){
		    	
          
            while (Total >= 500)
            {
               
			 Total = Total - 500;
                i++;
            }
          
            
            while (Total >= 200)
            {
                Total = Total - 200;
                c++;
            }
         
            while (Total >= 100)
            {
                Total = Total - 100;
                d++;
            }
        

            while (Total >= 50)
            {
                Total = Total - 50;
                E++;
            }
      
            while (Total >= 20)
            {
                Total = Total - 20;
                f++;
            }
       
            while (Total >= 10)
            {
                Total = Total - 10;
                g++;
            }
       

            while (Total >= 5)
            {
                Total = Total - 5;
                h++;
            }
            
            while (Total >= 2)
            {
                Total = Total - 2;
                j++;
            }
           
            while (Total >= 1)
            {
                Total = Total - 1;
                k++;
       
            }
            MessageBox.Show("Cantidad de billetes de 500 Euros :  " + i + "\n\n" + 
                                "Cantidad de billetes de 200 Euros :  " + c + "\n\n" + 
                                "Cantidad de billetes de 100 Euros  :  " + d + "\n\n" + 
                                "Cantidad de billetes de 50 Euros :  " + E + "\n\n" + 
                                "Cantidad de billetes de 20 Euros :  " + f + "\n\n" + 
                                "Cantidad de billetes de 10 Euros :  " + g + "\n\n" + 
                                "Cantidad de billetes de 5 Euros :  " + h + "\n\n" +
                                "Cantidad de monedas de 2 Euros :  " + j + "\n\n" +
                                "Cantidad de monedas de 1 Euro :  " + k);
                               
                               
            }
               
		                                   
              if(monedas.Text == "Real."){
		    	
          
            while (Total >= 100)
            {
               
			 Total = Total - 100;
                i++;
            }
          
            
            while (Total >= 50)
            {
                Total = Total - 50;
                c++;
            }
         
            while (Total >= 20)
            {
                Total = Total - 20;
                d++;
            }
        

            while (Total >= 10)
            {
                Total = Total - 10;
                E++;
            }
      
            while (Total >= 5)
            {
                Total = Total - 5;
                f++;
            }
       
            while (Total >= 2)
            {
                Total = Total - 2;
                g++;
            }
       

            while (Total >= 1)
            {
                Total = Total - 1;
                h++;
            }
            
           
            MessageBox.Show("Cantidad de billetes de 100 Reale :  " + i + "\n\n" + 
                                "Cantidad de billetes de 50 Reales :  " + c + "\n\n" + 
                                "Cantidad de billetes de 20 Reales  :  " + d + "\n\n" + 
                                "Cantidad de billetes de 10 Reales:  " + E + "\n\n" + 
                                "Cantidad de billetes de 5 Reales :  " + f + "\n\n" + 
                                "Cantidad de billetes de 2 Reales :  " + g + "\n\n" + 
                                "Cantidad de billetes de 1 Real :  " + h );
                               
            
		    }
		    
		       if(monedas.Text == "Libra."){
		       	
		       
		   while (Total >= 50)
            {
                Total = Total - 50;
                i++;
            }
            

            while (Total >= 20)
            {
                Total = Total - 20;
                c++;
            }
       
            while (Total >= 10)
            {
                Total = Total - 10;
                d++;
            }
           
            while (Total >= 5)
            {
                Total = Total - 5;
                E++;
            }
          
            while (Total >= 2)
            {
                Total = Total - 2;
                f++;
            }
          
            while (Total >= 1)
            {
                Total = Total - 1;
                g++;
            }
		    
             MessageBox.Show("Cantidad de billetes de 50 Libras :  " + i + "\n\n" + 
                              "Cantidad de billetes de 20 Libras :  " + c + "\n\n" + 
                              "Cantidad de billetes de 10 Libras :  " + d + "\n\n" + 
                              "Cantidad de billetes de 5 Libras :  " + E + "\n\n" + 
                              "Cantidad de monedas de 2 Libras :  " + f + "\n\n" + 
                              "Cantidad de monedas de 1 Libra :  " + g );
                               
        
		   }
		
		       if(monedas.Text == "Peso Uruguayo."){
		       	
		     
		       
		       while (Total >= 2000)
            {
                Total = Total - 2000;
                i++;
            }
        

            while (Total >= 1000)
            {
                Total = Total - 1000;
                c++;
            }
        

            while (Total >= 500)
            {
                Total = Total - 500;
                d++;
            }
         

            while (Total >= 200)
            {
                Total = Total - 200;
                E++;
            }
         
            while (Total >= 100)
            {
                Total = Total - 100;
                f++;
            }
          

            while (Total >= 50)
            {
                Total = Total - 50;
                g++;
            }
         
            while (Total >= 20)
            {
                Total = Total - 20;
                h++;
            }
           
            while (Total >= 10)
            {
                Total = Total - 10;
                j++;
            }
          

            while (Total >= 5)
            {
                Total = Total - 5;
                k++;
            }
         

            while (Total >= 2)
            {
                Total = Total - 2;
                l++;
            }
        
            while (Total >= 1)
            {
                Total = Total - 1;
                m++;
            }
			
            MessageBox.Show("Cantidad de billetes de 2000 Pesos Uruguayos :  " + i + "\n\n" + 
                                "Cantidad de billetes de 1000 Pesos Uruguayos  :  " + c + "\n\n" + 
                                "Cantidad de billetes de 500 Pesos Uruguayos :  " + d + "\n\n" + 
                                "Cantidad de billetes de 200 Pesos Uruguayos :  " + E + "\n\n" + 
                                "Cantidad de billetes de 100 Pesos Uruguayos :  " + f + "\n\n" + 
                                "Cantidad de billetes de 50 Pesos Uruguayos :  " + g + "\n\n" +
                                "Cantidad de billetes de 20 Pesos Uruguayos :  " + h + "\n\n" +
                                "Cantidad de billetes de 10 Pesos Uruguayos :  " + j + "\n\n" +
                                "Cantidad de monedas de 5 Pesos Uruguayos :  " + k + "\n\n" +
                                "Cantidad de monedas de 2 Pesos Uruguayos :  " + l + "\n\n" +
                                "Cantidad de monedas de 1 Pesos Uruguayos :  " + m);
                                
		   }
		}
    }
}
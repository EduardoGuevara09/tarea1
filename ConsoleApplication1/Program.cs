using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1

{
   class Program
    {
        static int option = 0;
        public void deposito (int cuenta)
             {
                
                
                
             }
               
        static void Main(string[] args)
        {
            int option, cuenta, monto_cuenta, monto, billetes2,billetes5,billetes10,billetes20,temp,monedas500,monedas100,monedas50,monedas25,monedas10,monedas5,monedas,monto_monedas,compra_dolares,venta_dolares,tipo_cambio,dolares;
             
          monto_cuenta = 0;
          monto= 0;
          billetes2=0;
          billetes5=0;
          billetes10=0;
          billetes20=0;
          monedas = 0;
          compra_dolares =531;
          venta_dolares = 544;
          monto_monedas = 0;
          tipo_cambio = 0;
          dolares=0;
          do
            {
               Console.Clear();                
               Console.WriteLine("                CAJERO BANCO ESTADO");
               Console.WriteLine("                   1. Depósito de dinero");
               Console.WriteLine("                   2. Retiro de dinero");
               Console.WriteLine("                   3. Recibo de monedas.");
               Console.WriteLine("                   4. Tipo de cambio.");
               Console.WriteLine("                   5. Salir.");
               Console.Write("                  Selecciones una opción:");
                option = int.Parse(Console.ReadLine());
                switch (option)
                 {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("    CAJERO BANCO ESTADO");
                            Console.Write("        Digite numero de cuenta:");
                            cuenta = int.Parse(Console.ReadLine());
                            Console.Write("        Digite monto a depositar:");
                            monto = int.Parse(Console.ReadLine());
                            monto_cuenta = (monto_cuenta + monto);
                            Console.Write("        Su saldo actual es de:", monto_cuenta);
                            Console.WriteLine(monto_cuenta);
                            Console.WriteLine("        Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                            //deposito(cuenta);
                        }
                    break;

                    case 2:
                        {
                           if (monto_cuenta>0)
                           {       Console.Clear();
                                   Console.WriteLine("    CAJERO BANCO ESTADO");
                                   Console.Write("        Digite numero de cuenta:");
                                   cuenta = int.Parse(Console.ReadLine());
                                   Console.Write("        Digite monto a retirar:");
                                   monto = int.Parse(Console.ReadLine());
                                   if (monto<=monto_cuenta)
                                     {
                                        monto_cuenta = (monto_cuenta - monto);                                         
                                        temp = monto;
                                        while (temp >=20000)
                                            {
                                                billetes20=billetes20+1;
                                                temp = (temp - 20000);                                                
                                            }
                                        while ((temp >= 10000)&&(temp<20000))
                                        {
                                            billetes10 = billetes10 + 1;
                                            temp = (temp - 10000);
                                        } 
                                       while ((temp >= 5000) && (temp < 10000))
                                        {
                                            billetes5 = billetes5 + 1;
                                            temp = (temp - 5000);
                                        }
                                       while (temp >= 2000)
                                       {
                                           billetes2 = billetes2 + 1;
                                           temp = (temp - 2000);
                                       }

                                       Console.Write("     Billetes de ¢20000:");
                                       Console.WriteLine(billetes20);
                                       Console.Write("     Billetes de ¢10000:");
                                       Console.WriteLine(billetes10);
                                       Console.Write("     Billetes de ¢5000:");
                                       Console.WriteLine(billetes5);
                                       Console.Write("     Billetes de ¢2000:");
                                       Console.WriteLine(billetes2);
                                       Console.Write("     El saldo de su cuenta es:¢");
                                       Console.WriteLine(monto_cuenta);
                                       Console.Write("     PRESIONE CUALQUIER TECLA PARA CONTINUAR...");
                                       Console.ReadKey();
                                     }  
                                   else
                                     {
                                       Console.WriteLine("        Error, su saldo en la cuenta es menor al que desea retirar, intente de nuevo");
                                       Console.Write("            PRESIONE CUALQUIER TECLA PARA CONTINUAR...");
                                       Console.ReadKey();

                                     }
                           }
                           break;
                           }
                    
                    case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("    CAJERO BANCO ESTADO");
                        Console.Write("        Digite numero de cuenta:");
                        cuenta = int.Parse(Console.ReadLine());
                        Console.Write("        Digite la cantidad de Monedas de ¢500:");
                        monedas500= int.Parse(Console.ReadLine());
                        monedas = (monedas500 + monedas);
                        monto_monedas = (monto_monedas + monedas500 * 500);
                        Console.Write("        Digite la cantidad de Monedas de ¢100:");
                        monedas100 = int.Parse(Console.ReadLine());
                        monedas = (monedas100 + monedas);
                        monto_monedas = (monto_monedas + monedas100 * 100);
                        Console.Write("        Digite la cantidad de Monedas de ¢50:");
                        monedas50 = int.Parse(Console.ReadLine());
                        monedas = (monedas50 + monedas);
                        monto_monedas = (monto_monedas + monedas50 * 50);
                        Console.Write("        Digite la cantidad de Monedas de ¢25:");
                        monedas25 = int.Parse(Console.ReadLine());
                        monedas = (monedas25 + monedas);
                        monto_monedas = (monto_monedas + monedas25 * 25);
                        Console.Write("        Digite la cantidad de Monedas de ¢10:");
                        monedas10 = int.Parse(Console.ReadLine());
                        monedas = (monedas10 + monedas);
                        monto_monedas = (monto_monedas + monedas10 * 10);
                        Console.Write("        Digite la cantidad de Monedas de ¢5:");
                        monedas5 = int.Parse(Console.ReadLine());
                        monedas = (monedas5 + monedas);
                        monto_monedas = (monto_monedas + monedas5 * 5);
                        Console.Write("     Cantidad de monedas de ¢500:");
                        Console.WriteLine(monedas500);
                        Console.Write("    Cantidad de monedas de ¢100:");
                        Console.WriteLine(monedas100);
                        Console.Write("     Cantidad de monedas de ¢50");
                        Console.WriteLine(monedas50);
                        Console.Write("     Cantidad de monedas de ¢25:");
                        Console.WriteLine(monedas25);
                        Console.Write("     Cantidad de monedas de ¢10:");
                        Console.WriteLine(monedas10);
                        Console.Write("     Cantidad de monedas de ¢5:");
                        Console.WriteLine(monedas5);
                        Console.Write("     Monto total de monedas es:¢");
                        Console.WriteLine(monto_monedas);
                        monto_cuenta = (monto_cuenta + monto_monedas);
                        Console.Write("     El saldo de su cuenta es:¢");
                        Console.WriteLine(monto_cuenta);
                        Console.Write("     PRESIONE CUALQUIER TECLA PARA CONTINUAR...");
                        Console.ReadKey();
                        
                    }
                    break;
                    case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("    CAJERO BANCO ESTADO");
                        Console.WriteLine("    TIPO DE CAMBIO AL DIA DE HOY");
                        Console.Write("Compra:");
                        Console.WriteLine(compra_dolares);
                        Console.Write("Venta:");
                        Console.WriteLine(venta_dolares);
                        Console.WriteLine("     1.Colones-Dolares");
                        Console.WriteLine("     2.Dolares-Colones");
                        Console.Write("Eliga su opcion:");
                        option = int.Parse(Console.ReadLine());
                        if (option==1)
                        {
                            Console.Clear();
                            Console.WriteLine("   CAJERO BANCO ESTADO");
                            Console.Write("       Digite el monto en colones:");
                            dolares = int.Parse(Console.ReadLine());
                            Console.Write("       Para compra:$");
                            tipo_cambio = dolares / compra_dolares;
                            Console.WriteLine(tipo_cambio);
                            Console.Write("       Para venta:$"); 
                            tipo_cambio = dolares / venta_dolares;
                            Console.WriteLine(tipo_cambio);
                            Console.Write("      PRESIONE CUALQUIER TECLA PARA CONTINUAR...");
                            Console.ReadKey();               
                         }
                         if (option==2)
                        {
                            Console.Clear();
                            Console.WriteLine("    CAJERO BANCO ESTADO");
                            Console.Write("        Digite el monto en dolares:");
                            dolares = int.Parse(Console.ReadLine());
                            Console.Write("       Para compra:¢");
                            tipo_cambio = dolares * compra_dolares;
                            Console.WriteLine(tipo_cambio);
                            Console.Write("       Para venta:¢"); 
                            tipo_cambio = dolares * venta_dolares;
                            Console.WriteLine(tipo_cambio);
                            Console.Write("     PRESIONE CUALQUIER TECLA PARA CONTINUAR...");
                            Console.ReadKey();                                          
                         }
                    break;
                 }
               }
            }


          while (option != 5);
          
        }
    }
}

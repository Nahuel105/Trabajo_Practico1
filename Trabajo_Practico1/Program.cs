using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, destino, clase="";
            int dni, edad, claseVuelo, equipaje, equipajePago= 0, perroServicio, modificarDatos, dniTutor, servicioMNA = 0, cantidadEquipaje = 0, pesoEquipaje = 0;
            int pesoExcedido= 0, precioExcedido = 0;
            Random random = new Random();
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string letra1 = letras[random.Next(0, letras.Length)].ToString();
            string letra2 = letras[random.Next(0, letras.Length)].ToString();
            string tarjetaEmbarque = letra1 + letra2 + random.Next(10000, 99999);
            DateTime dateTime = DateTime.Now;

            Console.WriteLine("Hola! Bienvenido a QualityFly \nA continuación se solicitará que ingrese una serie de datos");
            Console.WriteLine("Ingrese su nombre completo por favor");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su DNI sin puntos");
            dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            if(edad >= 2 && edad < 5)
            {
                Console.WriteLine("Ingrese el DNI del responsable a cargo");
                dniTutor = int.Parse(Console.ReadLine());
            }
            else if (edad >= 5 && edad < 11)
            {
                Console.WriteLine("Puede realizar el viaje solo si accede al servicio de menor no acompañado \nDe caso contrario ingresar DNI del tutor");
                Console.WriteLine("Si desea acceder al servicio presione 1 \nde caso contrario presione 0");
                servicioMNA = int.Parse(Console.ReadLine());
                if (servicioMNA == 0)
                {
                    Console.WriteLine("Ingrese DNI del responsable a cargo");
                    dniTutor = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Ingrese su destino final");
            destino = Console.ReadLine();
            Console.WriteLine("Usted abonó su vuelo? \nEconómico(1) \nEjecutiva(2) \nPrimera Clase(3)");
            claseVuelo = int.Parse(Console.ReadLine());
            switch (claseVuelo)
            {
                case 1:  clase = "Económico";
                    break;
                    case 2: clase = "Ejecutiva";
                    break;
                    case 3: clase = "Primera clase";
                    break;
            }
            Console.WriteLine("Posee usted equipaje de mano? \nSI(1) \nNO(2)");
            equipaje = int.Parse(Console.ReadLine());
            if(equipaje == 1)
            {
                Console.WriteLine("Ingrese la cantidad de equipaje");
                cantidadEquipaje = int.Parse(Console.ReadLine());

                if (cantidadEquipaje > 3)
                {
                    Console.WriteLine("Usted se está excediendo \nEl limite permitido por pasajero es 3! \nPor favor reingrese una cantidad que este permitida");
                    cantidadEquipaje = int.Parse(Console.ReadLine());
                    if (cantidadEquipaje <= 3){
                        Console.WriteLine("Usted esta dentro de los limites permitidos");
                    }
                }

                Console.WriteLine("Tiene el equipaje en bodeja facturado? \nSI(1) \nNO(2)");
                equipajePago = int.Parse(Console.ReadLine());
                if (equipajePago == 2)
                {
                    switch (claseVuelo)
                    {
                        case 1:
                            Console.WriteLine("Su vuelo es económico \nTiene permitido llevar hasta 5kg");
                            Console.WriteLine("Cuanto pesa su equipaje?");
                            pesoEquipaje = int.Parse(Console.ReadLine());
                            if (pesoEquipaje > 5)
                            {
                                Console.WriteLine("Usted se está excediendo del peso permitido \nDeberá abonar $10 adicionales por cada Kg de más");
                                pesoExcedido = pesoEquipaje - 5;
                                precioExcedido = pesoExcedido *  10;
                                Console.WriteLine("El precio final a abonar por el excedente de peso es $" + precioExcedido);
                            }
                            break;
                            case 2:
                            Console.WriteLine("Su vuelo es ejecutivo \nTiene permitido llevar hasta 10kg");
                            Console.WriteLine("Cuanto pesa su equipaje?");
                            pesoEquipaje = int.Parse(Console.ReadLine());
                            if (pesoEquipaje > 10)
                            {
                                Console.WriteLine("Usted se está excediendo del peso permitido \nDeberá abonar $10 adicionales por cada Kg de más");
                                pesoExcedido = pesoEquipaje - 10;
                                precioExcedido = pesoExcedido * 10;
                                Console.WriteLine("El precio final a abonar por el excedente de peso es $" + precioExcedido);
                            }

                            break;
                            case 3:
                            Console.WriteLine("Su vuelo es primera clase \nTiene permitido llevar hasta 20kg");
                            Console.WriteLine("Cuanto pesa su equipaje?");
                            pesoEquipaje = int.Parse(Console.ReadLine());
                            if (pesoEquipaje > 20)
                            {
                                Console.WriteLine("Usted se está excediendo del peso permitido \nDeberá abonar $10 adicionales por cada Kg de más");
                                pesoExcedido = pesoEquipaje - 20;
                                precioExcedido = pesoExcedido * 10;
                                Console.WriteLine("El precio final a abonar por el excedente de peso es $" + precioExcedido);
                            }
                            break;
                    }

                }

            }

            Console.WriteLine("Viaja usted con perro de servicio? \nSI(1) \nNO(2)");
            perroServicio = int.Parse(Console.ReadLine());
            if (perroServicio == 1)
            {
                Console.WriteLine("Debera usted contar con un distintivo de servicio \ntambien con una correa para asegurarlo con el cinturón de seguridad");
            }

            Console.WriteLine("\n \n \n \n \n \n");

            Console.WriteLine("Pasajero/a: " + nombre + "\nDNI: " + dni + "\nEdad: " + edad + "\nDestino: " + destino + "\nClase de vuelo: " +clase);
            if (edad >= 2 && edad < 5)
            {
                Console.WriteLine("DNI Tutor: " + dniTutor);
            }
            else if (edad >= 5 && edad < 11)
            {
                switch (servicioMNA)
                {
                    case 1:
                        Console.WriteLine("Servicio menor no acompañado: SI");
                        break;
                    case 0:
                        Console.WriteLine("DNI Tutor: " + dniTutor);
                        break;
                }
            }
            Console.WriteLine($"Equipaje de mano: {(equipaje == 1 ? "Sí" : "No")}" + ($"\nEquipaje de facturado: {(equipajePago == 1 ? "Sí" : "No")}") + $"\nPerro de servicio: {(perroServicio == 1 ? "Sí" : "No")}" + "\nAbonar por valijas: " +"$"+ precioExcedido);
            Console.WriteLine("Numero: " + tarjetaEmbarque + "\nFecha y hora: " + dateTime + "\nMuchos exitos en " + destino+" le desea QualityFLy \nGracias por elegirnos!");
            
            Console.Read();
              

            
        }
    }
}

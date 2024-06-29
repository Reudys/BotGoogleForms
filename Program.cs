using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        while (a <= 200)
        {
            a++;
            IWebDriver driver = null;
            try
            {
                CloseChromeDriverProcesses();
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://docs.google.com/forms/d/e/1FAIpQLSewZDkogyrfR_Mxf8vlnPW_1luBeYkYN_Oxat909CA172ZEKQ/viewform");
                
                //Espera explícitamente a que el elemento sea cliclable
                Thread.Sleep(2000);

                // ID's de los radio button
                String[] IdR1 = {"i5","i8","i11","i14","i17","i20"}; 

                // Seleccionamos el radio button por su ID
                var radioButton = driver.FindElement(By.Id(IdR1[NumRandom6(IdR1.Length)]));

                // Simulamos hacer clic en el radio button
                radioButton.Click();
                //-------------------------
                String[] IdR2 = {"i27","i30","i33","i36"};
                var radioButton2 = driver.FindElement(By.Id(IdR2[NumRandom4(IdR2.Length)]));
                radioButton2.Click();
                //-------------------------
                String[] IdR3 = {"i43","i46","i49","i52","i55","i58"};
                var radioButton3 = driver.FindElement(By.Id(IdR3[NumRandom6(IdR3.Length)]));
                radioButton3.Click();
                //-------------------------
                String[] IdR4 = {"i65","i68","i71","i74","i77"};
                var radioButton4 = driver.FindElement(By.Id(IdR4[NumRandom5(IdR4.Length)]));
                radioButton4.Click();
                //-------------------------
                String[] IdR5 = {"i84","i87","i90","i93","i96"};
                var radioButton5 = driver.FindElement(By.Id(IdR5[NumRandom5(IdR5.Length)]));
                radioButton5.Click();
                //-------------------------
                String[] IdR6 = {"i103","i106","i109","i112","i115"};
                var radioButton6 = driver.FindElement(By.Id(IdR6[NumRandom5(IdR6.Length)]));
                radioButton6.Click();
                //-------------------------
                String[] IdR7 = {"i122","i125","i128","i131","i134"};
                var radioButton7 = driver.FindElement(By.Id(IdR7[NumRandom5(IdR7.Length)]));
                radioButton7.Click();
                //-------------------------
                String[] IdR8 = {"i141","i144","i147","i150","i153"};
                var radioButton8 = driver.FindElement(By.Id(IdR8[NumRandom5(IdR8.Length)]));
                radioButton8.Click();
                //-------------------------
                String[] IdR9 = {"i160","i163","i166","i169","i172"};
                var radioButton9 = driver.FindElement(By.Id(IdR9[NumRandom5(IdR9.Length)]));
                radioButton9.Click();
                //-------------------------
                String[] IdR10 = {"i179","i182","i185","i188","i191"};
                var radioButton10 = driver.FindElement(By.Id(IdR10[NumRandom5(IdR10.Length)]));
                radioButton10.Click();
                //-------------------------
                String[] IdR11 = {"i198","i201","i204","i207","i210"};
                var radioButton11 = driver.FindElement(By.Id(IdR11[NumRandom5(IdR11.Length)]));
                radioButton11.Click();
                //-------------------------
                String[] IdR12 = {"i217","i220","i223","i226","i229"};
                var radioButton12 = driver.FindElement(By.Id(IdR12[NumRandom5(IdR12.Length)]));
                radioButton12.Click();
                //-------------------------
                String[] IdR13 = {"i236","i239","i242","i245","i248"};
                var radioButton13 = driver.FindElement(By.Id(IdR13[NumRandom5(IdR13.Length)]));
                radioButton13.Click();
                //-------------------------
                String[] IdR14 = {"i255","i258","i261","i264","i267"};
                var radioButton14 = driver.FindElement(By.Id(IdR14[NumRandom5(IdR14.Length)]));
                radioButton14.Click();
                //-------------------------
                String[] IdR15 = {"i274","i277","i280","i283","i286"};
                var radioButton15 = driver.FindElement(By.Id(IdR15[NumRandom5(IdR15.Length)]));
                radioButton15.Click();
                //-------------------------
                String[] IdR16 = {"i293","i296","i299","i302","i305"};
                var radioButton16 = driver.FindElement(By.Id(IdR16[NumRandom5(IdR16.Length)]));
                radioButton16.Click();
                //-------------------------
                String[] IdR17 = {"i312","i315","i318","i321","i324"};
                var radioButton17 = driver.FindElement(By.Id(IdR17[NumRandom5(IdR17.Length)]));
                radioButton17.Click();
                //-------------------------
                String[] IdR18 = {"i331","i334","i337","i340","i343"};
                var radioButton18 = driver.FindElement(By.Id(IdR18[NumRandom5(IdR18.Length)]));
                radioButton18.Click();
                //-------------------------
                String[] IdR19 = {"i350","i353","i356","i359","i362"};
                var radioButton19 = driver.FindElement(By.Id(IdR19[NumRandom5(IdR19.Length)]));
                radioButton19.Click();
                //-------------------------
                String[] IdR20 = {"i369","i372","i375","i378","i381"};
                var radioButton20 = driver.FindElement(By.Id(IdR20[NumRandom5(IdR20.Length)]));
                radioButton20.Click();
                Thread.Sleep(1000);
                //-------------------------

                // Encontrar el div por su Clase
                IWebElement divElement = driver.FindElement(By.ClassName("uArJ5e"));

                // Obtener la posición del div
                Point divLocation = divElement.Location;
                int xPosition = divLocation.X;
                int yPosition = divLocation.Y;

                Console.WriteLine($"La posición del div es X: {xPosition}, Y: {yPosition}");

                // Mover el mouse al centro del div
                Actions actions = new Actions(driver);
                actions.MoveToElement(divElement).Perform();

                // Hacer clic en el div
                divElement.Click();

                // Cerrar el navegador
                //driver.Quit();
                ConsoleColor realColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Datos Enviados, Total de envios: " + (a-1));
                Console.ForegroundColor = realColor;
                System.Threading.Thread.Sleep(3000);
            }
            finally
            {
                // Cierra el navegador al finalizar
                if (driver != null)
                {
                    driver.Quit();
                    driver.Dispose();
                }

                Thread.Sleep(3000);
            }
        }
    }

    static void CloseChromeDriverProcesses()
    {
        foreach (var process in Process.GetProcessesByName("chromedriver"))
        {
            try
            {
                process.Kill();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo cerrar el proceso de ChromeDriver: " + ex.Message);
            }
        }
    }

    static int NumRandom4(int numRespuestas)
    {
        return GetRandomNormalIndex(numRespuestas);
    }

    static int NumRandom5(int numRespuestas)
    {
        return GetRandomNormalIndex(numRespuestas);
    }

    static int NumRandom6(int numRespuestas)
    {
        return GetRandomNormalIndex(numRespuestas);
    }

    static int GetRandomNormalIndex(int numRespuestas)
    {
        Random random = new Random();
        double mean = random.Next(0, numRespuestas); // Media aleatoria entre las opciones
        double stdDev = numRespuestas / 3.0; // Desviación estándar ajustada al rango de las opciones

        double u1 = 1.0 - random.NextDouble(); // uniform(0,1] random doubles
        double u2 = 1.0 - random.NextDouble();
        double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); // random normal(0,1)
        double randNormal = mean + stdDev * randStdNormal; // random normal(mean, stdDev^2)

        int response = (int)Math.Round(Math.Max(0, Math.Min(numRespuestas - 1, randNormal)));
        return response;
    }
}

using System.ServiceProcess;

void startup()
{

    Console.WriteLine("Stoppe Spooler");
    //Spooler stoppen
    ServiceController service = new("Spooler");
    if ((!service.Status.Equals(ServiceControllerStatus.Stopped)) &&
      (!service.Status.Equals(ServiceControllerStatus.StopPending)))
    {

        service.Stop();
        service.WaitForStatus(ServiceControllerStatus.Stopped);
    }

    Console.WriteLine("Starte Spooler");
    //Spooler starten
    service.Start();
    service.WaitForStatus(ServiceControllerStatus.Running);


}


Console.WriteLine("Spooler Neustarten");
startup();



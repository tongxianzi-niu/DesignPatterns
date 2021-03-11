using DesignPatterns.AdapterPattern;
using DesignPatterns.AdapterPatternExercise;
using DesignPatterns.CompositePattern;
using DesignPatterns.CompositePatternExercise;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FacadePattern;
using DesignPatterns.FactoryPattern;
using DesignPatterns.ProxyPatttern;
using DesignPatterns.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SingletonExample();
            FactoryExample();
            FacadeExample();
            AdapterExample();
            AdapterExercise();
            CompositeExample();
            CompositeExercise();
            ProxyExample();
            DecoratorExample();
        }

        public static void SingletonExample()
        {
            Singleton sltObject = Singleton.GetOject();
            sltObject.ShowMessage();
        }

        public static void FactoryExample()
        {
            BudgetKnifeStore store = new BudgetKnifeStore();
            store.OrderKnife("chefs");
        }

        public static void FacadeExample()
        {
            BankService myBankSvc = new BankService();
            int mySaving = myBankSvc.CreateNewAccount("saving", new decimal(500.00));
            int myInvestment = myBankSvc.CreateNewAccount("investment", new decimal(1000.00));
            myBankSvc.TransferMoney(mySaving, myInvestment, new decimal(300.00));
        }

        public static void AdapterExample()
        {
            string webHost = "https://google.com";
            HttpClient webService = new HttpClient();
            webService.BaseAddress = new Uri(webHost);
            WebAdapter adapter = new WebAdapter();
            adapter.Connect(webService);
            WebClient client = new WebClient(adapter);
            client.DoWork();
        }

        public static void AdapterExercise()
        {
            OldCoffeeMachine oldMachine = new OldCoffeeMachine();
            CoffeeTouchscreenAdapter adapter = new CoffeeTouchscreenAdapter(oldMachine);
            adapter.ChooseFirstSelection();
        }

        public static void CompositeExample()
        {
            Housing building = new Housing("123 Street");
            Housing floor1 = new Housing("123 Street - First Floor");
            int firstFloor = building.AddStructure(floor1);
            Room washroom1m = new Room("1F Men's Washroom");
            Room washroom1w = new Room("1F Women's Washroom");
            Room common1 = new Room("1F Common Area");
            int firstMens = floor1.AddStructure(washroom1m);
            int firstWomens = floor1.AddStructure(washroom1w);
            int firstCommon = floor1.AddStructure(common1);
            building.Enter();
            Housing currFloor = (Housing)building.GetStructure(firstFloor);
            currFloor.Enter();
            Room currRoom = (Room)currFloor.GetStructure(firstMens);
            currRoom.Enter();
            currRoom = (Room)currFloor.GetStructure(firstCommon);
            currRoom.Enter();
        }

        public static void CompositeExercise()
        {
            // Make new empty "Study" playlist 
            PlayList studyPlaylist = new PlayList("Study");

            // Make "Synth Pop" playlist and Add 2 songs to it.
            PlayList synthPopPlaylist = new PlayList("Synth Pop");
            Song synthPopSong1 = new Song("Girl Like You", "Toro Y Moi");
            Song synthPopSong2 = new Song("Outside", "TOPS");
            synthPopPlaylist.Add(synthPopSong1);
            synthPopPlaylist.Add(synthPopSong2);

            // Make "Experimental" playlist and Add 3 songs to it, 
            // then set playback speed of the playlist to 0.5x
            PlayList experimentalPlaylist = new PlayList("Experimental");
            Song experimentalSong1 = new Song("About you", "XXYYXX");
            Song experimentalSong2 = new Song("Motivation", "Clams Casino");
            Song experimentalSong3 = new Song("Computer Vision", "Oneohtrix Point Never");
            experimentalPlaylist.Add(experimentalSong1);
            experimentalPlaylist.Add(experimentalSong2);
            experimentalPlaylist.Add(experimentalSong3);
            float slowSpeed = 0.5f;
            experimentalPlaylist.SetPlaybackSpeed(slowSpeed);

            // Add the "Synth Pop" playlist to the "Experimental" playlist
            experimentalPlaylist.Add(synthPopPlaylist);

            // Add the "Experimental" playlist to the "Study" playlist
            studyPlaylist.Add(experimentalPlaylist);

            // Create a new song and set its playback speed to 1.25x, play this song, 
            // get the name of glitchSong → "Textuell", then get the artist of this song → "Oval"
            Song glitchSong = new Song("Textuell", "Oval");
            float fasterSpeed = 1.25f;
            glitchSong.SetPlaybackSpeed(fasterSpeed);
            glitchSong.Play();
            String name = glitchSong.GetName();
            String artist = glitchSong.GetArtist();
            Console.WriteLine("The song name is " + name);
            Console.WriteLine("The song artist is " + artist);

            // Add glitchSong to the "Study" playlist
            studyPlaylist.Add(glitchSong);

            // Play "Study" playlist.
            studyPlaylist.Play();

            // Get the playlist name of studyPlaylist → "Study"
            Console.WriteLine("The Playlist's name is " + studyPlaylist.GetName());
        }

        public static void ProxyExample()
        {
            Dictionary<string, int> stockInW1 = new Dictionary<string, int>();
            stockInW1.Add("apple", 1);
            stockInW1.Add("orange", 3);
            Warehouse warehouse1 = new Warehouse(stockInW1, "warehouse 1");
            Dictionary<string, int> stockInW2 = new Dictionary<string, int>();
            stockInW2.Add("apple", 4);
            stockInW2.Add("orange", 2);
            Warehouse warehouse2 = new Warehouse(stockInW2, "warehouse 2");
            List<Warehouse> warehouses = new List<Warehouse>() { warehouse1, warehouse2 };
            OrderFulfillment orderFulfillment = new OrderFulfillment(warehouses);
            List<Item> items = new List<Item>();
            items.Add(new Item() { Sku = "apple" });
            items.Add(new Item() { Sku = "apple" });
            Order order = new Order() { ItemList = items };
            orderFulfillment.FulfillOrder(order);
        }

        public static void DecoratorExample()
        {
            var circle = new Circle();
            var redCircle = new RedShapeDecorator(new Circle());
            var redRectangle = new RedShapeDecorator(new Rectangle());
            circle.Draw();
            redCircle.Draw();
            redRectangle.Draw();
        }
    }
}

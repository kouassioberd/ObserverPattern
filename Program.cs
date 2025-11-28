using ObserverPattern;


User user1 = new("User 1");
User user2 = new("User 2");
School school1 = new("School 1");
School school2 = new("School 2");

NewsAgency newsAgency = new();

newsAgency.RegisterObserver(user1);
newsAgency.RegisterObserver(school1);
newsAgency.NotifyObservers("News 1");

Console.WriteLine();

newsAgency.RegisterObserver(user2);
newsAgency.RegisterObserver(school2);
newsAgency.NotifyObservers("News 2");

Console.WriteLine();

newsAgency.RemoveObserver(user1);
newsAgency.RemoveObserver(school1);

newsAgency.NotifyObservers("New 3");




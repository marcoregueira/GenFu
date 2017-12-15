GenFu 
===========
If you're looking for GenFu, please check the official repo...
http://genfu.io/ 



This fork allows GenFu instantiation and multithreading, making it more reliable for unit testing and web scenarios.

```
var childGenerator = new GenFuInstance();
var adultGenerator = new GenFuInstance();

childGenerator.Configure<Person>().Fill(x => x.Age).WithinRange(1, 10);
adultGenerator.Configure<Person>().Fill(x => x.Age).WithinRange(20, 100);
```

Classic static usage still works, but now it is usable in concurrent scenarios. For instance, this test won't fail.

```
        [Fact]
        public void registrations_can_be_reset()
        {
            Parallel.For(0, 10000, i =>
               {
                   A.New<Profile>();
                   A.Reset();
               });
        }
```

namespace test_nextech_api;

public class UnitTest1
{
    class DummyService
    {
        public List<String> GuestTypes { get; set; }

        public List<String> GetGuestType() => GuestTypes;
    }

    [Fact]
    public void Test1()
    {

    }
}

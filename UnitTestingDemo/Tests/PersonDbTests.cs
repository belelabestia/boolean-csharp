using NUnit.Framework;
using UnitTestingDemo;

namespace Tests
{
    [TestFixture]
    public class PersonDbTests
    {
        PersonDb db;

        [SetUp]
        public void Setup()
        {
            db = new PersonDb();
        }

        [Test]
        [Description("Insert should add without throwing")]
        public void Insert_AddsWithoutError()
        {
            var p = new Person { Age = 1, Name = "Marco" };
            Assert.DoesNotThrow(() => db.Insert(p));
        }

        [Test]
        [Description("Insert should fail if Name is empty string")]
        public void Insert_FailsOnEmptyName()
        {
            var p = new Person { Name = "" };
            Assert.Throws<ArgumentException>(() => db.Insert(p));
        }

        [Test]
        [Description("Insert should fail if Age is negative")]
        public void Insert_FailsOnNegativeAge()
        {
            var p = new Person { Age = -1 };
            Assert.Throws<ArgumentException>(() => db.Insert(p));
        }

        [Test]
        [Description("FilterPeopleByName should return filtered list")]
        [TestCase("Paolo", 2)]
        [TestCase("Anna", 1)]
        [TestCase("Giorgia", 0)]
        public void Insert_ReturnsFilteredList(string name, int expected)
        {
            var paolo1 = new Person { Name = "Paolo" };
            var paolo2 = new Person { Name = "Paolo" };
            var anna = new Person { Name = "Anna" };
            var michele = new Person { Name = "Michele" };
            var otto = new Person { Name = "Otto" };

            db.Insert(paolo1);
            db.Insert(paolo2);
            db.Insert(anna);
            db.Insert(michele);
            db.Insert(otto);

            var result = db.FilterPeopleByName(name);

            Assert.That(result, Has.Count.EqualTo(expected));
        }
    }
}

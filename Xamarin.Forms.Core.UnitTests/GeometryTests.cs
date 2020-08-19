using NUnit.Framework;
using Xamarin.Forms.Shapes;

namespace Xamarin.Forms.Core.UnitTests
{
	public class GeometryTests : BaseTestFixture
	{
		[SetUp]
		public override void Setup()
		{
			base.Setup();

			Device.SetFlags(new[] { ExperimentalFlags.ShapesExperimental });
		}

		[Test]
		public void TestRoundLineGeometryConstruction()
		{
			var lineGeometry = new LineGeometry(new Point(0, 0), new Point(100, 100));

			Assert.IsNotNull(lineGeometry);
			Assert.AreEqual(0, lineGeometry.StartPoint.X);
			Assert.AreEqual(0, lineGeometry.StartPoint.Y);
			Assert.AreEqual(100, lineGeometry.EndPoint.X);
			Assert.AreEqual(100, lineGeometry.EndPoint.Y);
		}

		[Test]
		public void TestEllipseGeometryConstruction()
		{
			var ellipseGeometry = new EllipseGeometry(new Point(50, 50), 10, 20);

			Assert.IsNotNull(ellipseGeometry);
			Assert.AreEqual(50, ellipseGeometry.Center.X);
			Assert.AreEqual(50, ellipseGeometry.Center.Y);
			Assert.AreEqual(10, ellipseGeometry.RadiusX);
			Assert.AreEqual(20, ellipseGeometry.RadiusY);
		}

		[Test]
		public void TestRectangleGeometryConstruction()
		{
			var rectangleGeometry = new RectangleGeometry(new Rect(0, 0, 150, 150));

			Assert.IsNotNull(rectangleGeometry);
			Assert.AreEqual(150, rectangleGeometry.Rect.Height);
			Assert.AreEqual(150, rectangleGeometry.Rect.Width);
		}

		[Test]
		public void TestRoundRectangleGeometryConstruction()
		{
			var roundRectangleGeometry = new RoundRectangleGeometry(new CornerRadius(12, 0, 0, 12), new Rect(0, 0, 150, 150));

			Assert.IsNotNull(roundRectangleGeometry);
			Assert.AreEqual(12, roundRectangleGeometry.CornerRadius.TopLeft);
			Assert.AreEqual(0, roundRectangleGeometry.CornerRadius.TopRight);
			Assert.AreEqual(0, roundRectangleGeometry.CornerRadius.BottomLeft);
			Assert.AreEqual(12, roundRectangleGeometry.CornerRadius.BottomRight);
			Assert.AreEqual(150, roundRectangleGeometry.Rect.Height);
			Assert.AreEqual(150, roundRectangleGeometry.Rect.Width);
		}
	}
}

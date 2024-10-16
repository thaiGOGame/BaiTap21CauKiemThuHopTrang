using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai15
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data15.csv", "data15#csv", DataAccessMethod.Sequential), DeploymentItem("data15.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            int year = int.Parse(TestContext.DataRow[0].ToString());
            bool expected = bool.Parse(TestContext.DataRow[1].ToString());
            bool actual = methods.IsLeapYear(year);
            Assert.AreEqual(expected, actual);
        }
    }
}

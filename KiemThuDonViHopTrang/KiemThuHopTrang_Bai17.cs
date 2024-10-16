using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai17
    {

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data17.csv", "data17#csv", DataAccessMethod.Sequential), DeploymentItem("data17.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            byte day = byte.Parse(TestContext.DataRow[0].ToString());
            byte month = byte.Parse(TestContext.DataRow[1].ToString());
            short year = short.Parse(TestContext.DataRow[2].ToString());
            bool expected = bool.Parse(TestContext.DataRow[3].ToString());
            bool act = methods.IsValidDate(year, month, day);
            Assert.AreEqual(expected,act);

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai20
    {

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data20.csv", "data20#csv", DataAccessMethod.Sequential), DeploymentItem("data20.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            char input = char.Parse(TestContext.DataRow[0].ToString());
            int expected = int.Parse(TestContext.DataRow[1].ToString());
            int act = methods.IsInString(input);
            Assert.AreEqual(expected, act);

        }
    }
}

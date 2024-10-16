using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThuVienKiemThuHopTrang;
using System;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai7
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
     "|DataDirectory|\\Data7.csv", "Data7#csv",
 DataAccessMethod.Sequential),
 DeploymentItem("Data7.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            ushort year = ushort.Parse(TestContext.DataRow[0].ToString());
            byte month = byte.Parse(TestContext.DataRow[1].ToString());
            byte exp_result = byte.Parse(TestContext.DataRow[2].ToString());
            byte act_result = methods.DaysInMonth(year, month);
            Assert.AreEqual(exp_result, act_result);
        }
    }
}
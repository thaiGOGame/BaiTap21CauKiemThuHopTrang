using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThuVienKiemThuHopTrang;
using System;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai6
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
     "|DataDirectory|\\Data6.csv", "Data6#csv",
 DataAccessMethod.Sequential),
 DeploymentItem("Data6.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            double sum = double.Parse(TestContext.DataRow[0].ToString());
            double count = double.Parse(TestContext.DataRow[1].ToString());
            double exp_result = double.Parse(TestContext.DataRow[2].ToString());
            double act_result = methods.Average(sum, count);
            Assert.AreEqual(exp_result, act_result);
        }
    }
}
namespace Module2Assignment
{
    public class EmployeeReportService
    {
        private string report = "";

        public void AddData(String data) {
            report += data;
        }

        public void OutputReport(object println) {
            OutputReport(report);
        }

        public void ClearReport() {
            report = "";
        }

    }

    public class String
    {
    }
}
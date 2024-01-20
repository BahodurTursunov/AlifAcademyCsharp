namespace erm
{
    internal class Program
    {
        internal enum Probability // возможность
        {
            High,
            Medium,
            Low
        }
        internal enum Impact // влияние
        {
            High,
            Medium,
            Low
        }

        public class Risk
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public Probability Probability { get; set; }
            public Impact Impact { get; set; }
        }

        public class RiskCategory
        {
            public string Name { get; set; }

            public void AddRisk(Risk risk)
            {
                Console.WriteLine($"Risk '{risk.Name}' added in category '{Name}'.");
            }
        }

        public class RiskAssessment
        {
            public DateTime Date { get; set; }
            public List<Risk> AssessedRisks { get; set; }

            public void AddAssessedRisk(Risk risk)
            {
                AssessedRisks.Add(risk);
                Console.WriteLine($"Risk '{risk.Name}' added in risk assessment on {Date.ToShortDateString()}.");
            }
        }

        public class RiskManager
        {
            public List<RiskCategory> RiskCategories { get; set; }
            public List<RiskAssessment> Assessments { get; set; }

            public Risk CreateRisk(string name, string description, Probability probability, Impact impact)
            {
                Risk newRisk = new()
                {
                    Name = name,
                    Description = description,
                    Probability = probability,
                    Impact = impact
                };
                return newRisk;
            }

            public void CreateRiskCategory(string name)
            {
                RiskCategory riskCategory = new()
                {
                    Name = name
                };
                RiskCategories.Add(riskCategory);
                Console.WriteLine($"Risk category '{riskCategory.Name}' added in RiskCategories");
            }

            public void CreateRiskAssessment(DateTime date)
            {
                RiskAssessment assessment = new RiskAssessment
                {
                    Date = date,
                    AssessedRisks = new List<Risk>()
                };
                Assessments.Add(assessment);
                Console.WriteLine($"RiskAssessment added in Assessments on '{assessment.Date}'");
            }
        }

        public class ERMSystem
        {
            public RiskManager RiskManager { get; set; }
        }

        public static void Main(string[] args)
        {
            ERMSystem ermSystem = new ERMSystem();

            Risk risk = new()
            {
                Name = "risk1",
                Description = "Description",
                Probability = Probability.High,
                Impact = Impact.Low
            };

            Console.WriteLine(risk.Description);

            RiskCategory riskCategory = new()
            {
                Name = "High"
            };

            riskCategory.AddRisk(risk);

            RiskAssessment riskAssessment = new()
            {
                Date = DateTime.Today,
                AssessedRisks = new List<Risk>()
            };

            Console.WriteLine(riskAssessment.Date);
            riskAssessment.AddAssessedRisk(risk);

            RiskManager riskManager = new()
            {
                RiskCategories = new List<RiskCategory>(),
                Assessments = new List<RiskAssessment>()
            };

            riskManager.CreateRiskCategory("Financial");
            riskManager.CreateRiskAssessment(DateTime.Now);
        }
    }
}

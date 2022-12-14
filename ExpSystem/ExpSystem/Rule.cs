using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpSystem
{
    [Serializable]
    public class Rule
    {

        private List<Fact> reasons = new List<Fact>();

        public Fact Result { get; set; }

        public RuleWork Worked { get; set; }
        public string Name { get; set; }
        public string Reasoning { get; set; }

        #region Конструктор
        public Rule()
        {
        }
        public Rule(string name)
        {
            this.Name = name;
            Worked = RuleWork.No;
        }

        public Rule(Fact reason, Fact result)
        {
            this.reasons.Add(reason);
            this.Result = result;
            Worked = RuleWork.No;
        }
        #endregion

        public List<Fact> Reasons
        {
            get { return reasons; }
            set { reasons = value; }
        }

        public void AddReason(Fact f, int pos)
        {
            if ((pos < 0) || (pos > reasons.Count))
                throw new RuleException("Индекс находился вне границ списка посылок");
            if (this.Contains(f))
                throw new RuleException("Попытка добавить повторяющийся факт в список посылок");
            reasons.Add(f);
            Move(reasons.Count - 1, pos);
        }

        public Fact GetReason(int pos)
        {
            if ((pos < 0) || (pos > reasons.Count - 1))
                throw new RuleException("Индекс находился вне границ списка посылок");
            return reasons[pos];
        }

        public int ReasonCount()
        {
            return reasons.Count;
        }

        public void Move(int oldPos, int newPos)
        {
            if ((oldPos > reasons.Count - 1) || (newPos > reasons.Count - 1) || (oldPos < 0) || (newPos < 0))
                throw new RuleException("Индекс находился вне границ списка посылок");

            Fact pr = reasons[oldPos];
            if (oldPos > newPos)
            {
                for (int i = oldPos; i > newPos; i--)
                    reasons[i] = reasons[i - 1];
            }
            else
            {
                for (int i = oldPos; i < newPos; i++)
                    reasons[i] = reasons[i + 1];
            }
            reasons[newPos] = pr;
        }

        public void Move(Fact f, int newPos)
        {
            if (this.Contains(f))
                Move(this.IndexOf(f), newPos);
            else
                throw new RuleException("Запрашиваемая посылка не найдена");
        }

        public void Remove(int pos)
        {
            if ((pos > reasons.Count - 1) || (pos < 0))
                throw new RuleException("Индекс находился вне границ списка посылок");
            if (reasons.Count == 1)
                throw new RuleException("Попытка удалить едиственную посылку в правиле");
            reasons.RemoveAt(pos);
        }

        public void Remove(Fact f)
        {
            if (reasons.Count == 1)
                throw new RuleException("Попытка удалить едиственную посылку в правиле");
            if (this.Contains(f))
                reasons.RemoveAt(this.IndexOf(f));
            else
                throw new RuleException("Запрашиваемая посылка не найдена");
        }

        public bool Contains(Fact fact)
        {
            foreach (Fact f in reasons)
                if (f.CompareTo(fact) == 0)
                    return true;
            return false;
        }

        public int IndexOf(Fact fact)
        {
            for (int i = 0; i < reasons.Count; i++)
                if (reasons[i].CompareTo(fact) == 0)
                    return i;
            return -1;
        }

        public override string ToString()
        {
            if (reasons.Count > 0)
            {
                string s = "ЕСЛИ ";
                for (int i = 0; i < reasons.Count - 1; i++)
                    s += "(" + reasons[i].ToString() + ") И ";
                s += "(" + reasons[reasons.Count - 1] + ") ТОГДА ";
                if (Result != null)
                    s += Result.ToString();
                return s;
            }
            else
                return "";
        }
    }
}

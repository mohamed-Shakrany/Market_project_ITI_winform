using System.Data.Entity.Validation;

namespace SalesManagmentSystem2
{
    internal class FormattedDbEntityValidationException
    {
        private DbEntityValidationException e;

        public FormattedDbEntityValidationException(DbEntityValidationException e)
        {
            this.e = e;
        }
    }
}
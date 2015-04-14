using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasicsClasses.Accounts;
using CSharpProgrammingBasicsClasses.Common;
using CSharpProgrammingBasicsClasses.Interfaces;
using CSharpProgrammingBasicsClasses.Processors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSharpProgrammingBasicsTransactionApp
{
    public partial class frmMain : Form
    {
        ExceptionLogger exceptionLogger = new ExceptionLogger();
        public frmMain()
        {
            InitializeComponent();
        }

        #region Event Handlers

        /// <summary>
        /// CreateTransactionAccount method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            CreateAndPopulateTransactionAccount();
        }

        /// <summary>
        /// CreateDepositAccount method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    CreateAndPopulateDepositAccount();
                }
                catch (FormatException formatException)
                {
                    throw new UserInterfaceException(formatException);
                }
            }
            catch (UserInterfaceException UserInterfaceException)
            {

                exceptionLogger.InnerException = UserInterfaceException.InnerException;
                
            }


        }

        /// <summary>
        /// MakeTransaction method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    MakeTransaction();
                }
                catch (FormatException formatException)
                {
                    throw new UserInterfaceException(formatException);
                }


            }
            catch (UserInterfaceException UserInterfaceException)
            {
               exceptionLogger.InnerException = UserInterfaceException.InnerException;
            }
        }

        /// <summary>
        /// ChargeFee method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargeFee_Click(object sender, EventArgs e)
        {
            ChargeFee();
        }

        /// <summary>
        /// MakeGroupTransaction method is called
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            MakeGroupTransaction();
        }

        #endregion

        #region Account Methods

        /// <summary>
        /// This method checks the account type
        /// </summary>
        /// <param type="IAccount" name="account"></param>
        private void PopulateAccountProperties(IAccount account)
        {
            if (account is ITransactionAccount)
            {
                PopulateAccountFromProperties(account);
            }

            if (account is IDepositAccount)
            {
                PopulateAccountToProperties((IDepositAccount)account);
            }
        }

        /// <summary>
        /// This method fills specific labels
        /// </summary>
        /// <param type="IDepositAccount" name="depositAccount"></param>
        private void PopulateAccountToProperties(IDepositAccount depositAccount)
        {
            lblAccountToPropertiesID.Text = depositAccount.Id.ToString();
            lblAccountToPropertiesNumber.Text = depositAccount.Number.ToString();
            lblAccountToPropertiesCurrencyAmount.Text = depositAccount.Currency.ToString();
            lblAccountToPropertiesBalanceAmount.Text = depositAccount.Balance.Amount.ToString();
            lblAccountToPropertiesBalanceCurrencyBalance.Text = depositAccount.Balance.Currency.ToString();

            lblDepositPropertiesTimePeriodPeriod.Text = depositAccount.Period.Period.ToString();
            lblDepositPropertiesTimePeriodUnitOfTime.Text = depositAccount.Period.Unit.ToString();

            lblDepositPropertiesInterestRatePercent.Text = depositAccount.Interest.Percent.ToString();
            lblDepositPropertiesInterestRateUnitOfTime.Text = depositAccount.Interest.Unit.ToString();

            lblDepositPropertiesStartDate.Text = depositAccount.StartDate.ToShortDateString();
            lblDepositPropertiesEndDate.Text = depositAccount.EndDate.ToShortDateString();
        }

        /// <summary>
        /// This method fills specific labels
        /// </summary>
        /// <param type="IAccount" name="account"></param>
        private void PopulateAccountFromProperties(IAccount account)
        {
            lblAccountFromPropertiesID.Text = account.Id.ToString();
            lblAccountFromPropertiesNumber.Text = account.Number.ToString();
            lblAccountFromPropertiesCurrencyAmount.Text = account.Currency.ToString();
            lblAccountFromPropertiesBalanceAmount.Text = account.Balance.Amount.ToString();
            lblAccountFromPropertiesBalanceCurrnecyBalance.Text = account.Balance.Currency.ToString();

            lblTransactionAccountPropertiesLimitAmount.Text = account.Balance.Amount.ToString();
            lblTransactionAccountPropertiesLimitCurrency.Text = account.Balance.Currency.ToString();
        }

        /// <summary>
        /// This method creates the accounts that are specified 
        /// </summary>
        /// <param type="CreateAccountType" name="typesToCreate"></param>
        /// <returns>Dictionary<CreateAccountType, IAccount></returns>
        private Dictionary<CreateAccountType, IAccount> CreateAccounts(CreateAccountType typesToCreate)
        {
            var createAccounts = new Dictionary<CreateAccountType, IAccount>();

            if (typesToCreate.HasFlag(CreateAccountType.TransactionAccount))
            {
                ITransactionAccount newTransactionAccount = CreateTransactionAccount();
                createAccounts.Add(CreateAccountType.TransactionAccount, newTransactionAccount);
            }
            if (typesToCreate.HasFlag(CreateAccountType.DepositAccount))
            {
                IDepositAccount newDepositAccount = CreateDepositAccount();
                createAccounts.Add(CreateAccountType.DepositAccount, newDepositAccount);
            }
            if (typesToCreate.HasFlag(CreateAccountType.LoanAccount))
            {
                ILoanAccount newLoanAccount = CreateLoanAccount();
                createAccounts.Add(CreateAccountType.LoanAccount, newLoanAccount);
            }
            return createAccounts;
        }

        #endregion

        #region Transaction Account Methods

        /// <summary>
        /// Creates ITransactionAccount account
        /// </summary>
        /// <returns>ITransactionAccount</returns>
        private ITransactionAccount CreateTransactionAccount()
        {
            string currency = Convert.ToString(txtTransactionAccountCurrency.Text);
            decimal amount;

            if (txtTransactionAccountLimit.Text == "")
            {
                throw new FormatException("You have to enter account limit in order to procced");
            }
            else if (!Decimal.TryParse(txtTransactionAccountLimit.Text.ToString(), out amount))
            {
                throw new FormatException("Please enter valid decimal number for the limit");
            }
            else
            {

                if (txtTransactionAccountCurrency.Text == "")
                {
                    throw new FormatException("You have to enter account currency in order to procced");
                }

                else
                {
                    ITransactionAccount transactionAccount = new TransactionAccount(currency, amount);
                    return transactionAccount;
                }
            }
        }

        /// <summary>
        /// Creates new ITransactionAccount by calling the CreateTransactionAccount()
        /// </summary>
        private void CreateAndPopulateTransactionAccount()
        {
            ITransactionAccount transactionAccount = CreateTransactionAccount();

            PopulateAccountProperties(transactionAccount);
        }

        /// <summary>
        /// Clears specific labels
        /// </summary>
        private void ClearTransactionAccountProperties()
        {
            lblTransactionAccountPropertiesLimitAmount.Text = String.Empty;
            lblTransactionAccountPropertiesLimitCurrency.Text = String.Empty;
        }

        #endregion

        #region Deposit Account Methods

        /// <summary>
        /// Creates new account
        /// </summary>
        /// <returns>IDepositAccount</returns>
        private IDepositAccount CreateDepositAccount()
        {
            TimePeriod timePeriod = new TimePeriod();
            timePeriod.Period = Convert.ToInt32(txtDepositAccountTimePeriodPeriod.Text);
            timePeriod.Unit = SetUnitOfTimeFromComboBox(Convert.ToString(cbDepositAccountTimePeriodUnit.Text));

            InterestRate interestRate = new InterestRate();
            interestRate.Percent = Convert.ToDecimal(txtDepositAccountInterestRatePercent.Text);
            interestRate.Unit = SetUnitOfTimeFromComboBox(Convert.ToString(cbDepositAccountInterestRateUnit.Text));

            string currency = Convert.ToString(txtTransactionAccountCurrency.Text);
            DateTime startDate = Convert.ToDateTime(dtpDepositAccountStartDate.Text);
            DateTime endDate = Convert.ToDateTime(dtpDepositAccountEndDate.Text);
            ITransactionAccount transactionAccount = CreateTransactionAccount();
            IDepositAccount depositAccount = new DepositAccount(currency, timePeriod, interestRate, startDate, endDate, transactionAccount);

            return depositAccount;
        }

        /// <summary>
        /// Creates new IDepositAccount account by calling the CreateDepositAccount()
        /// </summary>
        private void CreateAndPopulateDepositAccount()
        {
            IDepositAccount depositAccount = CreateDepositAccount();
            PopulateAccountProperties(depositAccount);
        }

        /// <summary>
        /// Clears the Deposit Account specific labels
        /// </summary>
        private void ClearDepositAccountProperties()
        {
            lblDepositPropertiesTimePeriodPeriod.Text = String.Empty;
            lblDepositPropertiesTimePeriodUnitOfTime.Text = String.Empty;

            lblDepositPropertiesInterestRatePercent.Text = String.Empty;
            lblDepositPropertiesInterestRateUnitOfTime.Text = String.Empty;

            lblDepositPropertiesStartDate.Text = String.Empty;
            lblDepositPropertiesEndDate.Text = String.Empty;
        }

        #endregion

        #region Loan Account Methods

        /// <summary>
        /// Creates new accoung
        /// </summary>
        /// <returns>ILoanAccount</returns>
        private ILoanAccount CreateLoanAccount()
        {
            TimePeriod timePeriod = new TimePeriod();
            timePeriod.Period = Convert.ToInt32(txtDepositAccountTimePeriodPeriod.Text);
            timePeriod.Unit = SetUnitOfTimeFromComboBox(Convert.ToString(cbDepositAccountTimePeriodUnit.Text));

            InterestRate interestRate = new InterestRate();
            interestRate.Percent = Convert.ToDecimal(txtDepositAccountInterestRatePercent.Text);
            interestRate.Unit = SetUnitOfTimeFromComboBox(Convert.ToString(cbDepositAccountInterestRateUnit.Text));

            string currency = Convert.ToString(txtTransactionAccountCurrency.Text);
            DateTime startDate = Convert.ToDateTime(dtpDepositAccountStartDate.Text);
            DateTime endDate = Convert.ToDateTime(dtpDepositAccountEndDate.Text);
            ITransactionAccount transactionAccount = CreateTransactionAccount();
            ILoanAccount loanAccount = new LoanAccount(currency, timePeriod, interestRate, startDate, endDate, transactionAccount);

            return loanAccount;
        }

        #endregion

        #region Utility Methods

        /// <summary>
        /// Returns Unit of time value depending
        /// </summary>
        /// <param type=string name="s"></param>
        /// <returns>UnitOfTime</returns>
        private UnitOfTime SetUnitOfTimeFromComboBox(string s)
        {
            switch (s.ToLower())
            {
                case "day":
                    return UnitOfTime.Day;
                case "month":
                    return UnitOfTime.Month;
                case "year":
                    return UnitOfTime.Year;
                default:
                    return UnitOfTime.NothingSelected;
            }
        }

        /// <summary>
        /// Charges fee to DepositAccount and LoanAccount using the ChargeProcessingFee()
        /// </summary>
        private void ChargeFee()
        {
            IAccount[] accounts = new IAccount[2];

            CreateAccountType types = CreateAccountType.DepositAccount | CreateAccountType.LoanAccount;
            Dictionary<CreateAccountType, IAccount> accountsFromDictionary = CreateAccounts(types);

            CurrencyAmount amount = new CurrencyAmount { Amount = 15, Currency = "MKD" };

            accounts[0] = accountsFromDictionary[CreateAccountType.DepositAccount];
            accounts[1] = accountsFromDictionary[CreateAccountType.LoanAccount];

            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            transactionProcessor.ChargeProcessingFee(amount, accounts);
            DisplayLastTransactionDetails();
        }

        #endregion

        #region Transactions

        /// <summary>
        /// Makes a transaction between two accounts and displays the Last Transaction in the specific labels
        /// </summary>
        private void MakeTransaction()
        {
            ITransactionAccount transactonAccount = CreateTransactionAccount();
            IDepositAccount depositAccount = CreateDepositAccount();
            ILoanAccount loanAccount = CreateLoanAccount();
            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = Convert.ToDecimal(txtTransactionDetailsAmount.Text);
            ca.Currency = Convert.ToString(txtTransactionDetailsCurrency.Text);

            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();

            bool _errorOccured = false;
            string _errorMsg = "No error";

            try
            {
                transactionProcessor.ProcessTransaction(TransactionType.Transfer, ca, transactonAccount, depositAccount);
            }
            catch (CurrencyMismatchException ex)
            {
                _errorOccured = true;
                _errorMsg = ex.Message;
            }
            catch (ApplicationException)
            {
                throw;
            }
            finally
            {
                if (_errorOccured)
                {
                    MessageBox.Show(_errorMsg);
                }
            }

            DisplayLastTransactionDetails();
        }

        /// <summary>
        /// Makes a group transaction using flags enum and displays
        /// </summary>
        private void MakeGroupTransaction()
        {
            IAccount[] accounts = new IAccount[2];

            CreateAccountType types = CreateAccountType.DepositAccount | CreateAccountType.LoanAccount;
            Dictionary<CreateAccountType, IAccount> accountsFromDictionary = CreateAccounts(types);

            CurrencyAmount amount = new CurrencyAmount { Amount = 12345, Currency = "MKD" };

            accounts[0] = accountsFromDictionary[CreateAccountType.DepositAccount];
            accounts[1] = accountsFromDictionary[CreateAccountType.LoanAccount];

            ITransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();
            transactionProcessor.ProcessGroupTransaction(TransactionType.Debit, amount, accounts);
            DisplayLastTransactionDetails();
        }

        /// <summary>
        /// It takes the last transaction in TransactionProcessor
        /// </summary>
        private void DisplayLastTransactionDetails()
        {
            ITransactionProcessor processor = TransactionProcessor.GetTransactionProcessor();
            TransactionLogEntry lastEntry = processor[processor.TransactionCount - 1];

            lblLogEntryType.Text = lastEntry.TransactionType.ToString();
            lblLogEntryStatus.Text = lastEntry.Status.ToString();
            lblLogEntryCurrencyAmountAmount.Text = lastEntry.Amount.Amount.ToString();
            lblLogEntryCurrnecyAmountCurrency.Text = lastEntry.Amount.Currency.ToString();

            lblTransactionCount.Text = processor.TransactionCount.ToString();

            IAccount[] accounts = lastEntry.Accounts;
            PopulateAccountFromProperties(accounts[0]);
            PopulateAccountToProperties((IDepositAccount)accounts[1]);
        }

        #endregion

        private void gbCreateDepositAccount_Enter(object sender, EventArgs e)
        {

        }

        private void gbTransactionAccountProperties_Enter(object sender, EventArgs e)
        {

        }

        private void txtDepositAccountInterestRatePercent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

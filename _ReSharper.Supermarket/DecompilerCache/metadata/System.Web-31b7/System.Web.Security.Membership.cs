// Type: System.Web.Security.Membership
// Assembly: System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Web.dll

using System.Runtime;

namespace System.Web.Security
{
    /// <summary>
    /// Validates user credentials and manages user settings. This class cannot be inherited.
    /// </summary>
    public static class Membership
    {
        static Membership();

        /// <summary>
        /// Gets a value indicating whether the current membership provider is configured to allow users to retrieve their passwords.
        /// </summary>
        /// 
        /// <returns>
        /// true if the membership provider supports password retrieval; otherwise, false.
        /// </returns>
        public static bool EnablePasswordRetrieval { get; }

        /// <summary>
        /// Gets a value indicating whether the current membership provider is configured to allow users to reset their passwords.
        /// </summary>
        /// 
        /// <returns>
        /// true if the membership provider supports password reset; otherwise, false.
        /// </returns>
        public static bool EnablePasswordReset { get; }

        /// <summary>
        /// Gets a value indicating whether the default membership provider requires the user to answer a password question for password reset and retrieval.
        /// </summary>
        /// 
        /// <returns>
        /// true if a password answer is required for password reset and retrieval; otherwise, false.
        /// </returns>
        public static bool RequiresQuestionAndAnswer { get; }

        /// <summary>
        /// Specifies the number of minutes after the last-activity date/time stamp for a user during which the user is considered online.
        /// </summary>
        /// 
        /// <returns>
        /// The number of minutes after the last-activity date/time stamp for a user during which the user is considered online.
        /// </returns>
        public static int UserIsOnlineTimeWindow { get; }

        /// <summary>
        /// Gets a collection of the membership providers for the ASP.NET application.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipProviderCollection"/> of the membership providers configured for the ASP.NET application.
        /// </returns>
        public static MembershipProviderCollection Providers { get; }

        /// <summary>
        /// Gets a reference to the default membership provider for the application.
        /// </summary>
        /// 
        /// <returns>
        /// The default membership provider for the application exposed using the <see cref="T:System.Web.Security.MembershipProvider"/> abstract base class.
        /// </returns>
        public static MembershipProvider Provider { get; }

        /// <summary>
        /// The identifier of the algorithm used to hash passwords.
        /// </summary>
        /// 
        /// <returns>
        /// The identifier of the algorithm used to hash passwords, or blank to use the default hash algorithm.
        /// </returns>
        public static string HashAlgorithmType { get; }

        internal static bool IsHashAlgorithmFromMembershipConfig { get; }

        /// <summary>
        /// Gets the number of invalid password or password-answer attempts allowed before the membership user is locked out.
        /// </summary>
        /// 
        /// <returns>
        /// The number of invalid password or password-answer attempts allowed before the membership user is locked out.
        /// </returns>
        public static int MaxInvalidPasswordAttempts { get; }

        /// <summary>
        /// Gets the time window between which consecutive failed attempts to provide a valid password or password answer are tracked.
        /// </summary>
        /// 
        /// <returns>
        /// The time window, in minutes, during which consecutive failed attempts to provide a valid password or password answer are tracked. The default is 10 minutes. If the interval between the current failed attempt and the last failed attempt is greater than the <see cref="P:System.Web.Security.Membership.PasswordAttemptWindow"/> property setting, each failed attempt is treated as if it were the first failed attempt.
        /// </returns>
        public static int PasswordAttemptWindow { get; }

        /// <summary>
        /// Gets the minimum length required for a password.
        /// </summary>
        /// 
        /// <returns>
        /// The minimum length required for a password.
        /// </returns>
        public static int MinRequiredPasswordLength { get; }

        /// <summary>
        /// Gets the minimum number of special characters that must be present in a valid password.
        /// </summary>
        /// 
        /// <returns>
        /// The minimum number of special characters that must be present in a valid password.
        /// </returns>
        public static int MinRequiredNonAlphanumericCharacters { get; }

        /// <summary>
        /// Gets the regular expression used to evaluate a password.
        /// </summary>
        /// 
        /// <returns>
        /// A regular expression used to evaluate a password.
        /// </returns>
        public static string PasswordStrengthRegularExpression { get; }

        /// <summary>
        /// Gets or sets the name of the application.
        /// </summary>
        /// 
        /// <returns>
        /// The name of the application.
        /// </returns>
        public static string ApplicationName { get; set; }

        /// <summary>
        /// Adds a new user to the data store.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object for the newly created user.
        /// </returns>
        /// <param name="username">The user name for the new user. </param><param name="password">The password for the new user. </param><exception cref="T:System.Web.Security.MembershipCreateUserException">The user was not created. Check the <see cref="P:System.Web.Security.MembershipCreateUserException.StatusCode"/> property for a <see cref="T:System.Web.Security.MembershipCreateStatus"/> value. </exception>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static MembershipUser CreateUser(string username, string password);

        /// <summary>
        /// Adds a new user with a specified e-mail address to the data store.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object for the newly created user.
        /// </returns>
        /// <param name="username">The user name for the new user. </param><param name="password">The password for the new user. </param><param name="email">The e-mail address for the new user. </param><exception cref="T:System.Web.Security.MembershipCreateUserException">The user was not created. Check the <see cref="P:System.Web.Security.MembershipCreateUserException.StatusCode"/> property for a <see cref="T:System.Web.Security.MembershipCreateStatus"/> value. </exception>
        public static MembershipUser CreateUser(string username, string password, string email);

        /// <summary>
        /// Adds a new user with specified property values to the data store and returns a status parameter indicating that the user was successfully created or the reason the user creation failed.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object for the newly created user. If no user was created, this method returns null.
        /// </returns>
        /// <param name="username">The user name for the new user. </param><param name="password">The password for the new user. </param><param name="email">The e-mail address for the new user. </param><param name="passwordQuestion">The password-question value for the membership user.</param><param name="passwordAnswer">The password-answer value for the membership user.</param><param name="isApproved">A Boolean that indicates whether the new user is approved to log on.</param><param name="status">A <see cref="T:System.Web.Security.MembershipCreateStatus"/> indicating that the user was created successfully or the reason that creation failed. </param>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static MembershipUser CreateUser(string username, string password, string email, string passwordQuestion,
                                                string passwordAnswer, bool isApproved,
                                                out MembershipCreateStatus status);

        /// <summary>
        /// Adds a new user with specified property values and a unique identifier to the data store and returns a status parameter indicating that the user was successfully created or the reason the user creation failed.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object for the newly created user. If no user was created, this method returns null.
        /// </returns>
        /// <param name="username">The user name for the new user.</param><param name="password">The password for the new user.</param><param name="email">The e-mail address for the new user.</param><param name="passwordQuestion">The password-question value for the membership user.</param><param name="passwordAnswer">The password-answer value for the membership user.</param><param name="isApproved">A Boolean that indicates whether the new user is approved to log on.</param><param name="providerUserKey">The user identifier for the user that should be stored in the membership data store.</param><param name="status">A <see cref="T:System.Web.Security.MembershipCreateStatus"/> indicating that the user was created successfully or the reason creation failed.</param>
        public static MembershipUser CreateUser(string username, string password, string email, string passwordQuestion,
                                                string passwordAnswer, bool isApproved, object providerUserKey,
                                                out MembershipCreateStatus status);

        /// <summary>
        /// Verifies that the supplied user name and password are valid.
        /// </summary>
        /// 
        /// <returns>
        /// true if the supplied user name and password are valid; otherwise, false.
        /// </returns>
        /// <param name="username">The name of the user to be validated. </param><param name="password">The password for the specified user. </param>
        public static bool ValidateUser(string username, string password);

        /// <summary>
        /// Gets the information from the data source and updates the last-activity date/time stamp for the current logged-on membership user.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object representing the current logged-on user.
        /// </returns>
        public static MembershipUser GetUser();

        /// <summary>
        /// Gets the information from the data source for the current logged-on membership user. Updates the last-activity date/time stamp for the current logged-on membership user, if specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object representing the current logged-on user.
        /// </returns>
        /// <param name="userIsOnline">If true, updates the last-activity date/time stamp for the specified user. </param>
        public static MembershipUser GetUser(bool userIsOnline);

        /// <summary>
        /// Gets the information from the data source for the specified membership user.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object representing the specified user.
        /// </returns>
        /// <param name="username">The name of the user to retrieve.</param><exception cref="T:System.ArgumentException"><paramref name="username"/> contains a comma (,). </exception><exception cref="T:System.ArgumentNullException"><paramref name="username"/> is null.</exception>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static MembershipUser GetUser(string username);

        /// <summary>
        /// Gets the information from the data source for the specified membership user. Updates the last-activity date/time stamp for the user, if specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object representing the specified user.
        /// </returns>
        /// <param name="username">The name of the user to retrieve. </param><param name="userIsOnline">If true, updates the last-activity date/time stamp for the specified user. </param><exception cref="T:System.ArgumentException"><paramref name="username"/> contains a comma (,). </exception><exception cref="T:System.ArgumentNullException"><paramref name="username"/> is null.</exception>
        public static MembershipUser GetUser(string username, bool userIsOnline);

        /// <summary>
        /// Gets the information from the data source for the membership user associated with the specified unique identifier.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object representing the user associated with the specified unique identifier.
        /// </returns>
        /// <param name="providerUserKey">The unique user identifier from the membership data source for the user.</param><exception cref="T:System.ArgumentNullException"><paramref name="providerUserKey"/> is null. </exception>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public static MembershipUser GetUser(object providerUserKey);

        /// <summary>
        /// Gets the information from the data source for the membership user associated with the specified unique identifier. Updates the last-activity date/time stamp for the user, if specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUser"/> object representing the user associated with the specified unique identifier.
        /// </returns>
        /// <param name="providerUserKey">The unique user identifier from the membership data source for the user.</param><param name="userIsOnline">If true, updates the last-activity date/time stamp for the specified user.</param><exception cref="T:System.ArgumentNullException"><paramref name="providerUserKey"/> is null. </exception>
        public static MembershipUser GetUser(object providerUserKey, bool userIsOnline);

        /// <summary>
        /// Gets a user name where the e-mail address for the user matches the specified e-mail address.
        /// </summary>
        /// 
        /// <returns>
        /// The user name where the e-mail address for the user matches the specified e-mail address. If no match is found, null is returned.
        /// </returns>
        /// <param name="emailToMatch">The e-mail address to search for. </param>
        public static string GetUserNameByEmail(string emailToMatch);

        /// <summary>
        /// Deletes a user and any related user data from the database.
        /// </summary>
        /// 
        /// <returns>
        /// true if the user was deleted; otherwise, false.
        /// </returns>
        /// <param name="username">The name of the user to delete. </param><exception cref="T:System.ArgumentException"><paramref name="username"/> is an empty string or contains a comma (,). </exception><exception cref="T:System.ArgumentNullException"><paramref name="username"/> is null.</exception>
        public static bool DeleteUser(string username);

        /// <summary>
        /// Deletes a user from the database.
        /// </summary>
        /// 
        /// <returns>
        /// true if the user was deleted; otherwise, false.
        /// </returns>
        /// <param name="username">The name of the user to delete.</param><param name="deleteAllRelatedData">true to delete data related to the user from the database; false to leave data related to the user in the database.</param><exception cref="T:System.ArgumentException"><paramref name="username"/> is an empty string or contains a comma (,). </exception><exception cref="T:System.ArgumentNullException"><paramref name="username"/> is null.</exception>
        public static bool DeleteUser(string username, bool deleteAllRelatedData);

        /// <summary>
        /// Updates the database with the information for the specified user.
        /// </summary>
        /// <param name="user">A <see cref="T:System.Web.Security.MembershipUser"/> object that represents the user to be updated and the updated information for the user. </param><exception cref="T:System.ArgumentNullException"><paramref name="user"/> is null.</exception>
        public static void UpdateUser(MembershipUser user);

        /// <summary>
        /// Gets a collection of all the users in the database.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUserCollection"/> of <see cref="T:System.Web.Security.MembershipUser"/> objects representing all of the users in the database.
        /// </returns>
        public static MembershipUserCollection GetAllUsers();

        /// <summary>
        /// Gets a collection of all the users in the database in pages of data.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUserCollection"/> of <see cref="T:System.Web.Security.MembershipUser"/> objects representing all the users in the database for the configured applicationName.
        /// </returns>
        /// <param name="pageIndex">The index of the page of results to return. Use 0 to indicate the first page.</param><param name="pageSize">The size of the page of results to return. <paramref name="pageIndex"/> is zero-based.</param><param name="totalRecords">The total number of users.</param><exception cref="T:System.ArgumentException"><paramref name="pageIndex"/> is less than zero.-or-<paramref name="pageSize"/> is less than 1.</exception>
        public static MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);

        /// <summary>
        /// Gets the number of users currently accessing an application.
        /// </summary>
        /// 
        /// <returns>
        /// The number of users currently accessing an application.
        /// </returns>
        public static int GetNumberOfUsersOnline();

        /// <summary>
        /// Generates a random password of the specified length.
        /// </summary>
        /// 
        /// <returns>
        /// A random password of the specified length.
        /// </returns>
        /// <param name="length">The number of characters in the generated password. The length must be between 1 and 128 characters. </param><param name="numberOfNonAlphanumericCharacters">The minimum number of punctuation characters in the generated password.</param><exception cref="T:System.ArgumentException"><paramref name="length"/> is less than 1 or greater than 128 -or-<paramref name="numberOfNonAlphanumericCharacters"/> is less than 0 or greater than <paramref name="length"/>. </exception>
        public static string GeneratePassword(int length, int numberOfNonAlphanumericCharacters);

        /// <summary>
        /// Gets a collection of membership users, in a page of data, where the user name contains the specified user name to match.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUserCollection"/> that contains a page of <paramref name="pageSize"/><see cref="T:System.Web.Security.MembershipUser"/> objects beginning at the page specified by <paramref name="pageIndex"/>.Leading and trailing spaces are trimmed from the <paramref name="usernameToMatch"/> parameter value.
        /// </returns>
        /// <param name="usernameToMatch">The user name to search for.</param><param name="pageIndex">The index of the page of results to return. <paramref name="pageIndex"/> is zero-based.</param><param name="pageSize">The size of the page of results to return.</param><param name="totalRecords">The total number of matched users.</param><exception cref="T:System.ArgumentException"><paramref name="usernameToMatch"/> is an empty string.-or-<paramref name="pageIndex"/> is less than zero.-or-<paramref name="pageSize"/> is less than 1.</exception><exception cref="T:System.ArgumentNullException"><paramref name="usernameToMatch"/> is null.</exception>
        public static MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize,
                                                               out int totalRecords);

        /// <summary>
        /// Gets a collection of membership users where the user name contains the specified user name to match.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUserCollection"/> that contains all users that match the <paramref name="usernameToMatch"/> parameter.Leading and trailing spaces are trimmed from the <paramref name="usernameToMatch"/> parameter value.
        /// </returns>
        /// <param name="usernameToMatch">The user name to search for.</param><exception cref="T:System.ArgumentException"><paramref name="usernameToMatch"/> is an empty string.</exception><exception cref="T:System.ArgumentNullException"><paramref name="usernameToMatch"/> is null.</exception>
        public static MembershipUserCollection FindUsersByName(string usernameToMatch);

        /// <summary>
        /// Gets a collection of membership users, in a page of data, where the e-mail address contains the specified e-mail address to match.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUserCollection"/> that contains a page of <paramref name="pageSize"/><see cref="T:System.Web.Security.MembershipUser"/> objects beginning at the page specified by <paramref name="pageIndex"/>.
        /// </returns>
        /// <param name="emailToMatch">The e-mail address to search for.</param><param name="pageIndex">The index of the page of results to return. <paramref name="pageIndex"/> is zero-based.</param><param name="pageSize">The size of the page of results to return.</param><param name="totalRecords">The total number of matched users.</param><exception cref="T:System.ArgumentException"><paramref name="pageIndex"/> is less than zero.-or-<paramref name="pageSize"/> is less than 1.</exception>
        public static MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize,
                                                                out int totalRecords);

        /// <summary>
        /// Gets a collection of membership users where the e-mail address contains the specified e-mail address to match.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Web.Security.MembershipUserCollection"/> that contains all users that match the <paramref name="emailToMatch"/> parameter.Leading and trailing spaces are trimmed from the <paramref name="emailToMatch"/> parameter value.
        /// </returns>
        /// <param name="emailToMatch">The e-mail address to search for.</param>
        public static MembershipUserCollection FindUsersByEmail(string emailToMatch);

        /// <summary>
        /// Occurs when a user is created, a password is changed, or a password is reset.
        /// </summary>
        public static event MembershipValidatePasswordEventHandler ValidatingPassword;
    }
}

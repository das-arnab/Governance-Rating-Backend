using System;
using System.Collections.Generic;
using In.GovernanceRating.Entities;

namespace In.GovernanceRating.Repository
{
    public interface ICandidateRepository
    {
        /// <summary>
        /// TODO: Description
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Candidate GetCandidate(int id);

        /// <summary>
        /// TODO: Description
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        IList<Candidate> FindCandidates(string searchText);

        /// <summary>
        /// TODO: Description
        /// </summary>
        /// <param name="candidate"></param>
        void SaveCandidate(Candidate candidate);

        /// <summary>
        /// TODO: Description
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Candidate DeleteCandidate(int id);
    }
}

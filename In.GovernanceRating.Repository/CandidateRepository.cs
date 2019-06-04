using System;
using System.Collections.Generic;
using System.Text;
using In.GovernanceRating.Entities;

namespace In.GovernanceRating.Repository
{
    public class CandidateRepository: ICandidateRepository
    {
        private readonly CandidateContext _candidateContext;

        public CandidateRepository(CandidateContext candidateContext)
        {
            _candidateContext = candidateContext;
        }

        public Candidate GetCandidate(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Candidate> FindCandidates(string searchText)
        {
            throw new NotImplementedException();
        }

        public void SaveCandidate(Candidate candidate)
        {
            throw new NotImplementedException();
        }

        public Candidate DeleteCandidate(int id)
        {
            throw new NotImplementedException();
        }
    }
}

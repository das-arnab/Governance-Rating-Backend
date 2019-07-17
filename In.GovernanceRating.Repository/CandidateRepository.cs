using System;
using System.Collections.Generic;
using System.Text;
using In.GovernanceRating.Entities;

namespace In.GovernanceRating.Repository
{
    public class CandidateRepository: ICandidateRepository
    {
        private readonly ApplicationDbContext _context;

        public CandidateRepository(ApplicationDbContext context)
        {
            _context = context;
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

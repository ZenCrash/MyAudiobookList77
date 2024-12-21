using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAudiobookList.DataAccess.Repositorys
{
  public class AudiobookRepository
  {
    private readonly AudiobookContext _context;

    public AudiobookRepository(AudiobookContext context)
    {
      _context = context ?? throw new ArgumentNullException(nameof(context));
    }



  }
}

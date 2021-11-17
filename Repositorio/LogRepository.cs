using System;
using System.Collections.Generic;
using System.Linq;
using AppDomain.Entities;

namespace Repositorio
{
    public class LogRepository
    {
        private List<Log> _logs;

        public LogRepository()
        {
            _logs = new List<Log>();
        }

        public void AdicionarLog(Log log)
        {
            _logs.Add(log);
        }

        public void ExibirHistoricoLog()
        {
            foreach (var log in _logs)
            {
                Console.WriteLine(log.Mensagem + " "+ log.DataCriacao);
            }
        }

    }
}
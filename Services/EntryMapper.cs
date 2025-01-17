﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havit.Bonusario.Contracts;
using Havit.Bonusario.Model;
using Havit.Data.Patterns.UnitOfWorks;
using Havit.Diagnostics.Contracts;
using Havit.Extensions.DependencyInjection.Abstractions;
using Havit.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Havit.Bonusario.Services
{
	[Service]
	public class EntryMapper : IEntryMapper
	{
		private readonly IUnitOfWork unitOfWork;

		public EntryMapper(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public void MapFromEntryDto(EntryDto entryDto, Entry entry)
		{
			Contract.Requires<ArgumentNullException>(entry is not null, nameof(entry));
			Contract.Requires<ArgumentNullException>(entryDto is not null, nameof(entryDto));
			Contract.Requires<ArgumentException>(entryDto.RecipientId.HasValue, nameof(entryDto.RecipientId));

			entry.PeriodId = entryDto.PeriodId;
			entry.RecipientId = entryDto.RecipientId.Value;
			entry.Text = entryDto.Text;
			entry.Value = entryDto.Value;

			var result = entry.Tags.UpdateFrom(entryDto.Tags,
				et => et.Tag,
				dtoTag => dtoTag,
				dtoTag => new EntryTag() { Tag = dtoTag },
				(dtoTag, entryTag) => { },
				(entryTag) => { });

			unitOfWork.AddUpdateFromResult(result);
		}

		public EntryDto MapToEntryDto(Entry entry)
		{
			return new EntryDto()
			{
				Id = entry.Id,
				Text = entry.Text,
				CreatedById = entry.CreatedById,
				Created = entry.Created,
				RecipientId = entry.RecipientId,
				Submitted = entry.Submitted,
				Value = entry.Value,
				PeriodId = entry.PeriodId,
				Tags = entry.Tags.Select(et => et.Tag).ToList()
			};
		}
	}
}

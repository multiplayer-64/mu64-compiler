﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coop_builder
{
    public static class RepoUtil
    {
        public class Repo
        {
            public string user;
            public string repo;
            public string branch;

            public Repo(string user, string repo, string branch)
            {
                this.user = user;
                this.repo = repo;
                this.branch = branch;
            }

            public string ZipUrl()
            {
                return "https://github.com/" + user + "/" + repo + "/archive/refs/heads/" + branch + ".zip";
            }

            public string ExtractedFolder()
            {
                return repo + "-" + branch;
            }
        }

        public static Repo game = new Repo("multiplayer-64", "multiplayer64", "main");

        public static string tmpEnvironment32 = "mu64-compiler-32-bit";
        public static string tmpEnvironment64 = "mu64-compiler-64-bit";

        public static string environmentUrl32 = "https://github.com/multiplayer-64/mu64-compiler/archive/refs/heads/32-bit.zip";
        public static string environmentUrl64 = "https://github.com/multiplayer-64/mu64-compiler/archive/refs/heads/64-bit.zip";

        public static string intelHdFix32     = "https://github.com/multiplayer-64/mu64-compiler/raw/32-bit/intel-hd/opengl32.dll";
        public static string intelHdFix64     = "https://github.com/multiplayer-64/mu64-compiler/raw/64-bit/intel-hd/opengl32.dll";

        public static string releaseApiUrl   = "https://api.github.com/repos/multiplayer-64/mu64-compiler/releases/latest";
        public static string releaseExeUrl   = "https://github.com/multiplayer-64/mu64-compiler/releases/latest/download/mu64-compiler.exe";
    }
}
